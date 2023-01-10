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
            if (count == 7)
                count = 1;
        }

        private void CarTypeButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 CarTypeForm = new Form2();
            CarTypeForm.ShowDialog();
            Show();
        }

        private void EverestPictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 CarTypeForm = new Form2();
            CarTypeForm.ShowDialog();
            Show();
        }

        private void EverestLabel_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 CarTypeForm = new Form2();
            CarTypeForm.ShowDialog();
            Show();
        }

        private void ExplorerPictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 CarTypeForm = new Form2();
            CarTypeForm.ShowDialog();
            Show();
        }

        private void ExplorerLabel_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 CarTypeForm = new Form2();
            CarTypeForm.ShowDialog();
            Show();
        }

        private void RangerPictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 CarTypeForm = new Form2();
            CarTypeForm.ShowDialog();
            Show();
        }

        private void RangerLabel_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 CarTypeForm = new Form2();
            CarTypeForm.ShowDialog();
            Show();
        }

        private void RangerRaptorPictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 CarTypeForm = new Form2();
            CarTypeForm.ShowDialog();
            Show();
        }

        private void RangerRaptorLabel_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 CarTypeForm = new Form2();
            CarTypeForm.ShowDialog();
            Show();
        }

        private void TransitPictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 CarTypeForm = new Form2();
            CarTypeForm.ShowDialog();
            Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 CarTypeForm = new Form2();
            CarTypeForm.ShowDialog();
            Show();
        }

        private void HomeLabelButton_MouseEnter(object sender, EventArgs e)
        {
            HomeLabelButton.ForeColor = Color.Yellow;
        }

        private void HomeLabelButton_MouseLeave(object sender, EventArgs e)
        {
            HomeLabelButton.ForeColor = Color.White;
        }

        private void ServiceLabelButton_MouseEnter(object sender, EventArgs e)
        {
            ServiceLabelButton.ForeColor = Color.Yellow;

        }

        private void ServiceLabelButton_MouseLeave(object sender, EventArgs e)
        {
            ServiceLabelButton.ForeColor = Color.White;

        }

        private void PriceBoardLabelButton_MouseEnter(object sender, EventArgs e)
        {
            PriceBoardLabelButton.ForeColor = Color.Yellow;

        }

        private void PriceBoardLabelButton_MouseLeave(object sender, EventArgs e)
        {
            PriceBoardLabelButton.ForeColor = Color.White;

        }

        private void ContactLabelButton_MouseEnter(object sender, EventArgs e)
        {
            ContactLabelButton.ForeColor = Color.Yellow;
        }

        private void ContactLabelButton_MouseLeave(object sender, EventArgs e)
        {
            ContactLabelButton.ForeColor = Color.White;
        }
    }
}