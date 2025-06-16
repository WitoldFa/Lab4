namespace Lab4
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;

        private Bitmap OnlyGreen(Bitmap bmp)
        {
            Bitmap result = new Bitmap(bmp.Width, bmp.Height);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);

                    // Uznajemy piksel za zielony, jeśli zielony komponent jest dominujący
                    if (pixel.G > pixel.R + 30 && pixel.G > pixel.B + 30)
                    {
                        result.SetPixel(x, y, pixel);
                    }
                    else
                    {
                        result.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return result;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmapy (*.bmp)|*.bmp";
            ofd.Title = "Wczytaj obraz BMP";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(ofd.FileName);
                pictureBox1.Image = originalImage;
            }
        }

        private void btnGreenOnly_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Najpierw wczytaj obraz.");
                return;
            }

            pictureBox1.Image = OnlyGreen(originalImage);
        }
    }
}
