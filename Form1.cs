namespace Ford_Showroom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainFormCarPictureBox.BackgroundImage = (Bitmap)Properties.Resources.Car1;
            MainFormCarPictureBoxTimer.Start();
        }

        private void HomePanelCarIlluPictureBox_Click(object sender, EventArgs e)
        {

        }
        int count = 2;
        private void MainFormCarPictureBoxTimer_Tick(object sender, EventArgs e)
        {
            string tmp = "Car" + count.ToString();
            MainFormCarPictureBox.SuspendLayout();
            MainFormCarPictureBox.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(tmp.ToString());
            MainFormCarPictureBox.ResumeLayout();
            count++;
            if (count == 4)
                count = 1;
        }
    }
}