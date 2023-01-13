using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ford_Showroom
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string Name;
        int Count;
        public Form5(string SBackG, int count, string name)
        {
            InitializeComponent();
            PictureBox.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(SBackG);
            Name = name;
            this.Count = count;
        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Count++;
            if (Count > 6)
                Count = 1;
            string tmp = Name + Count.ToString();
            PictureBox.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(tmp);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Count--;
            if (Count == 0)
                Count = 6;
            string tmp = Name + Count.ToString();
            PictureBox.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(tmp);
        }
    }
}
