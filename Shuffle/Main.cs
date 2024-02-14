using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        List<Color> color = new List<Color>();

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
            else if (Clipboard.ContainsImage())
            {
                Image imageClip = Clipboard.GetImage();

                // Convert the image to a Bitmap
                image = new Bitmap(imageClip);
                pictureBox1.Image = ScaleImage(image, 996, 588);
            }

        }

        private void fkItUpBtn_Click(object sender, EventArgs e)
        {
            
            int seed = GetValidSeed(true);
            
            int encryptLvl = GetValidEncryptLvl(true);

            color = ColorListGet();
            Shuffle(seed, encryptLvl);
            SetImage();
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

        private List<Color> ColorListGet()
        {
            List<Color> holder = new List<Color>();
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    holder.Add(image.GetPixel(x, y));
                }
            }
            return holder;
        }

        private void SetImage()
        {
            int index = 0;
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    image.SetPixel(x, y, color[index++]);
                }
            }
        }

        private void Shuffle(int seed, int encryptLvl)
        {
            Stopwatch time = new Stopwatch();
            time.Start();

            // Store the original pixel colors in a list
                                 
            for (int i = 0; i < encryptLvl; i++)
            {
                
                // Shuffle the colors
                ShuffleList(color, Generate(color.Count, seed + i));
                
                // Update the image with the shuffled colors
                
            }
            
            
            Console.WriteLine("Encode: "+ time.ElapsedMilliseconds);
            
        }

        private void Unshuffle(Bitmap image, int seed, int encryptLevel)
        {
            
            Stopwatch time = new Stopwatch();
            time.Start();

            // Store the shuffled pixel colors in a list
            

            for (int i = encryptLevel - 1; i >= 0; i--)
            {
                Deshuffle(color, Generate(color.Count, seed + i));
            }
            // Unshuffle the colors


            
            Console.WriteLine("Decryption: " + time.ElapsedMilliseconds);
            
        }

        private int GetValidSeed(bool message)
        {
            int parsedSeed;
            if (int.TryParse(seedTxt.Text, out parsedSeed) && parsedSeed >= -2147483647 && parsedSeed + GetValidEncryptLvl(false) <= 2147483647)
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

        

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void SaveToFile()
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

            color = ColorListGet();
            Unshuffle(image, seed, encryptLvl);
            SetImage();
            Display(seed, encryptLvl);
        }


        private void unfkSequenceBtn_Click(object sender, EventArgs e)
        {
            ReadSequence(sqncTxt.Text);
            DialogResult result = MessageBox.Show("Do you want to encrypt or decrypt?", "Encryption/Decryption", MessageBoxButtons.YesNoCancel);
            color = ColorListGet();
            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < seeds.Count; i++)
                {
                    Shuffle(seeds[i], encryptLvls[i]);
                }

            }
            else if (result == DialogResult.No)
            {
                for (int i = seeds.Count - 1; i >= 0; i--)
                {
                    Unshuffle(image, seeds[i], encryptLvls[i]);
                }
            }
            SetImage();
            Display(0, 0);
        }

        private void Display(int seed, int encryptLvl)
        {
            seedTxt.Text = seed.ToString();
            encryptionLevelTxt.Text = encryptLvl.ToString();
            pictureBox1.Image = ScaleImage(image, 996, 588);
        }


        private void ReadSequence(string sequence)
        {
            seeds.Clear();
            encryptLvls.Clear();
            string[] substrings = sequence.Split(';');
            
            

            if (substrings.Length%2==1 || substrings.Length==0)
            {
                MessageBox.Show($"Invalid sequence", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                
                for (int i = 0; i < substrings.Length; i++)
                {
                    if (!int.TryParse(substrings[i], out int result))
                    {
                        seeds.Clear();
                        encryptLvls.Clear();
                        MessageBox.Show($"Invalid sequence", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (i % 2 == 1)
                        {
                            if (int.Parse(substrings[i]) > 0)
                            {
                                encryptLvls.Add(int.Parse(substrings[i]));
                            }
                            else
                            {
                                seeds.Clear();
                                encryptLvls.Clear();
                                MessageBox.Show($"Invalid encryption level in sequence", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            
                        }
                        else
                        {
                            seeds.Add(int.Parse(substrings[i]));
                            
                        }
                    }
                }
            }


        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(image);
        }
    }
}
