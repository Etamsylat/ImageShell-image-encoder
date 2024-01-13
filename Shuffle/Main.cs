using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Shuffle
{
    public partial class Main : Form
    {

        List<int> seeds = new List<int>();
        List<int> encryptLvls = new List<int>();
        Bitmap image = new Bitmap(100, 100);
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.png; *.bmp)|*.jpg; *.png; *.bmp|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1; // Default filter is the first one in the list
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                image = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = ScaleImage(image, 996, 588);
            }

        }

        private void fkItUpBtn_Click(object sender, EventArgs e)
        {

            int seed = GetValidSeed(true);
            int encryptLvl = GetValidEncryptLvl(true);

            image = Shuffle(seed, encryptLvl);

            Display(seed, encryptLvl);
        }

        private Bitmap ScaleImage(Bitmap originalImage, int maxWidth, int maxHeight)
        {
            // Calculate the scaling factor for width and height
            double widthScale = (double)maxWidth / originalImage.Width;
            double heightScale = (double)maxHeight / originalImage.Height;

            // Choose the smaller scaling factor to ensure that the image fits within the specified dimensions
            double scale = Math.Min(widthScale, heightScale);

            // Create an instance of the ResizeBilinear filter with the scaled dimensions
            ResizeBilinear filter = new ResizeBilinear((int)(originalImage.Width * scale), (int)(originalImage.Height * scale));

            // Apply the filter to the original image
            Bitmap scaledImage = filter.Apply(originalImage);

            return scaledImage;
        }

        private Bitmap Shuffle(int seed, int encryptLvl)
        {


            for (int i = 0; i < encryptLvl; i++)
            {
                List<Color> color = new List<Color>();
                // Store the original pixel colors in a list
                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        color.Add(image.GetPixel(x, y));
                    }
                }

                // Shuffle the colors
                ShuffleList(color, Generate(color.Count, seed + i));

                // Update the image with the shuffled colors
                int index = 0;
                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {
                        image.SetPixel(x, y, color[index++]);
                    }
                }
            }


            return image;
        }

        private int GetValidSeed(bool message)
        {
            int parsedSeed;
            if (int.TryParse(seedTxt.Text, out parsedSeed) && parsedSeed >= 0 && parsedSeed + GetValidEncryptLvl(false) <= 2147483647)
            {
                return parsedSeed;
            }
            else
            {
                Random rnd = new Random();
                parsedSeed = rnd.Next(2147483647 - GetValidEncryptLvl(false));
                if (message)
                {
                    MessageBox.Show($"Invalid seed input. Used random seed: {parsedSeed}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // You might want to handle this case more appropriately, like returning a default seed or prompting the user for a valid input.
                return parsedSeed; // Default seed in case of invalid input
            }
        }

        private int GetValidEncryptLvl(bool message)
        {
            int parsedSeed;
            if (int.TryParse(encryptionLevelTxt.Text, out parsedSeed) && parsedSeed > 0)
            {
                return parsedSeed;
            }
            else
            {
                if (message) { MessageBox.Show("Invalid encryption level input. Used default encryption level: 5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                // You might want to handle this case more appropriately, like returning a default seed or prompting the user for a valid input.
                return 5; // Default seed in case of invalid input
            }
        }

        public static List<int> Generate(int length, int seed)
        {
            Random random = new Random(seed);
            List<int> indexes = new List<int>();
            for (int i = 0; i < length; i++)
            {
                indexes.Add(random.Next(length));
            }
            return indexes;
        }

        public static List<Color> ShuffleList(List<Color> list, List<int> indexes)
        {
            for (int i = 0; i < indexes.Count; i++)
            {
                Color temp = list[i];
                list[i] = list[indexes[i]];
                list[indexes[i]] = temp;
            }
            return list;
        }

        public static List<Color> Deshuffle(List<Color> list, List<int> indexes)
        {

            for (int i = indexes.Count - 1; i >= 0; i--)
            {
                Color temp = list[i];
                list[i] = list[indexes[i]];
                list[indexes[i]] = temp;
            }
            return list;
        }

        private Bitmap Unfk(int seed, int encryptLvl)
        {
            for (int i = encryptLvl - 1; i >= 0; i--)
            {
                image = Unshuffle(image, i, seed);
            }
            return image;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp|All Files|*.*";
                saveFileDialog.Title = "Save an Image File";
                saveFileDialog.FileName = "output_image"; // Default file name


                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    string filePath = saveFileDialog.FileName;

                    // Save the image to the selected file path
                    image.Save(filePath, ImageFormat.Png);



                    // Create a new text file and write to it

                    MessageBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void unfkBtn_Click(object sender, EventArgs e)
        {
            int seed = GetValidSeed(false);
            if (seed.ToString() != seedTxt.Text)
            {
                MessageBox.Show($"Invalid seed input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int encryptLvl = GetValidEncryptLvl(true);
            image = Unfk(seed, encryptLvl);

            Display(seed, encryptLvl);
        }

        private Bitmap Unshuffle(Bitmap image, int offset, int seed)
        {
            List<Color> color = new List<Color>();

            // Store the shuffled pixel colors in a list
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    color.Add(image.GetPixel(x, y));
                }
            }


            // Unshuffle the colors
            Deshuffle(color, Generate(color.Count, seed + offset));

            // Update the image with the unshuffled colors
            int index = 0;
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    image.SetPixel(x, y, color[index++]);
                }
            }

            return image;
        }

        private void sequencerBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            seeds.Add(GetValidSeed(true));
            encryptLvls.Add(GetValidEncryptLvl(true));
            for (int i = 0; i < seeds.Count; i++)
            {
                label1.Text += seeds[i];
                label1.Text += encryptLvls[i];
            }
        }

        private void unfkSequenceBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to encrypt or decrypt?", "Encryption/Decryption", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < seeds.Count; i++)
                {
                    image = Shuffle(seeds[i], encryptLvls[i]);
                }

            }
            else if (result == DialogResult.No)
            {
                for (int i = seeds.Count - 1; i >= 0; i--)
                {
                    image = Unfk(seeds[i], encryptLvls[i]);
                }
            }
            Display(0, 0);
        }

        private void Display(int seed, int encryptLvl)
        {
            seedTxt.Text = seed.ToString();
            encryptionLevelTxt.Text = encryptLvl.ToString();
            pictureBox1.Image = ScaleImage(image, 996, 588);
        }
    }
}
