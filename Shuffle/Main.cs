using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shuffle
{
    public partial class Main : Form
    {

        List<int> seeds = new List<int>();
        List<int> encryptLvls = new List<int>();
        Bitmap image = new Bitmap(100, 100);
        List<Color> color = new List<Color>();
        bool SequenceGood = false;
        bool isImageIn = false;
        bool isPlaceholderTextDisplayed = true;

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
                isImageIn = true;
                // Get the selected file path
                image = new Bitmap(openFileDialog.FileName);
                displayBox.Image = ScaleImage(image, displayBox.Width, displayBox.Height);
            }
            else 
            {
                PasteImage();
            }


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

        private void PasteImage()
        {
            if (Clipboard.ContainsImage())
            {
                Image imageClip = Clipboard.GetImage();
                isImageIn = true;
                // Convert the image to a Bitmap
                image = new Bitmap(imageClip);
                displayBox.Image = ScaleImage(image, displayBox.Width, displayBox.Height);
            }
        }

        private void Shuffle(int seed, int encryptLvl)
        {


            // Store the original pixel colors in a list

            for (int i = 0; i < encryptLvl; i++)
            {

                // Shuffle the colors
                ShuffleList(color, Generate(color.Count, seed + i));

                // Update the image with the shuffled colors

            }




        }

        private void Unshuffle(Bitmap image, int seed, int encryptLevel)
        {



            // Store the shuffled pixel colors in a list


            for (int i = encryptLevel - 1; i >= 0; i--)
            {
                Deshuffle(color, Generate(color.Count, seed + i));
            }
            // Unshuffle the colors





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

        private void unfkSequenceBtn_Click(object sender, EventArgs e)
        {
            if (isImageIn)
            {
                ReadSequence(sqncTxt.Text);
                if (!SequenceGood)
                {
                    return;
                }
                color = ColorListGet();
                for (int i = seeds.Count - 1; i >= 0; i--)
                {
                    Unshuffle(image, seeds[i], encryptLvls[i]);
                }

                SetImage();
                Display(0, 0);
            }
        }

        private void Display(int seed, int encryptLvl)
        {

            displayBox.Image = ScaleImage(image, 996, 588);
        }

        private void ReadSequence(string sequence)
        {
            seeds.Clear();
            encryptLvls.Clear();
            string[] substrings = sequence.Split(';');



            if (substrings.Length % 2 == 1 || substrings.Length == 0)
            {
                MessageBox.Show($"Invalid sequence", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SequenceGood = false;
                return;
            }
            else
            {

                for (int i = 0; i < substrings.Length; i++)
                {
                    if (!int.TryParse(substrings[i], out int result))
                    {
                        SequenceGood = false;
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
                                SequenceGood = false;
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
            SequenceGood = true;

        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(image);
        }

        private void encodeBtn_Click(object sender, EventArgs e)
        {
            if (isImageIn)
            {
                ReadSequence(sqncTxt.Text);
                if (!SequenceGood)
                {
                    return;
                }
                color = ColorListGet();
                for (int i = 0; i < seeds.Count; i++)
                {
                    Shuffle(seeds[i], encryptLvls[i]);
                }

                SetImage();
                Display(0, 0);
            }
        }

        

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            PasteImage();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Ctrl key is pressed along with another key
            if (e.Control)
            {
                // Check if Ctrl + C is pressed
                if (e.KeyCode == Keys.C && isImageIn)
                {
                    Clipboard.SetImage(image);
                    
                }
                // Check if Ctrl + V is pressed
                else if (e.KeyCode == Keys.V)
                {
                    PasteImage();
                }
            }
        }

        private void sqncTxt_Enter(object sender, EventArgs e)
        {
            if (isPlaceholderTextDisplayed)
            {
                sqncTxt.Text = "";
                sqncTxt.ForeColor = SystemColors.WindowText; // or any other color you prefer
                isPlaceholderTextDisplayed = false;
            }
        }

        private void sqncTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sqncTxt.Text))
            {
                sqncTxt.Text = "Enter seed...";
                sqncTxt.ForeColor = Color.Gray;
                isPlaceholderTextDisplayed = true;
            }
        }

        
    }
}
