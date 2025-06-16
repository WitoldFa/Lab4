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

        private Bitmap RotateImage(Bitmap source, float angle)
        {
            float radian = angle * (float)Math.PI / 180f;
            float cos = Math.Abs((float)Math.Cos(radian));
            float sin = Math.Abs((float)Math.Sin(radian));
            int newWidth = (int)(source.Width * cos + source.Height * sin);
            int newHeight = (int)(source.Width * sin + source.Height * cos);

            Bitmap rotated = new Bitmap(newWidth, newHeight);
            rotated.SetResolution(source.HorizontalResolution, source.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotated))
            {
                g.TranslateTransform(newWidth / 2f, newHeight / 2f);
                g.RotateTransform(angle);
                g.TranslateTransform(-source.Width / 2f, -source.Height / 2f);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(source, new Point(0, 0));
            }

            return rotated;
        }

        private Bitmap InvertColors(Bitmap bmp)
        {
            Bitmap result = new Bitmap(bmp.Width, bmp.Height);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    Color inverted = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    result.SetPixel(x, y, inverted);
                }
            }
            return result;
        }

        private Bitmap FlipVertically(Bitmap bmp)
        {
            Bitmap result = new Bitmap(bmp);
            result.RotateFlip(RotateFlipType.RotateNoneFlipY);
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

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Najpierw wczytaj obraz.");
                return;
            }

            float angle = 0;
            if (radio90.Checked) angle = 90;
            else if (radio180.Checked) angle = 180;
            else if (radio270.Checked) angle = 270;
            else
            {
                MessageBox.Show("Wybierz kąt obrotu.");
                return;
            }

            pictureBox1.Image = RotateImage(originalImage, angle);
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Najpierw wczytaj obraz.");
                return;
            }

            pictureBox1.Image = InvertColors(originalImage);
        }

        private void btnUpsideDown_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Najpierw wczytaj obraz.");
                return;
            }

            pictureBox1.Image = FlipVertically(originalImage);
        }
    }
}
