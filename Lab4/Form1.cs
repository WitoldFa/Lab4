namespace Lab4
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
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
    }
}
