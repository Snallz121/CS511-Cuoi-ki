using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ford_Showroom
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CarTypeFormPictureBox.BackgroundImage = Properties.Resources.Car1;
        }

        string FullName, Name; // Save necessary material
        string[] EverestColor = { "_BLACK", "_GRAY", "_ORANGERED", "_WHITE" };
        string[] ExplorerColor = { "_BLACK", "_BLUE", "_RED", "_WHITE" };
        string[] RangerColor = { "_BLACK", "_ORANGERED", "_SILVER", "_WHITE", "_YELLOW" };
        string[] RangerRaptorColor = { "_BLACK", "_BLUE", "_GRAY", "_RED", "_WHITE" };
        string[] TransitColor = { "_BLACK", "_BROWN","_GRAY", "_RED", "_SILVER","_WHITE" };
        string[] Color1 = {};

        public Form2(string FullName1, string Name1)
        {
            InitializeComponent();
            FullName = FullName1;
            Name = Name1;

            // Chọn màu

            switch(Name1)
            {
                case "Everest":
                    Color1 = EverestColor;
                    break;
                case "Explorer":
                    Color1 = ExplorerColor;
                    break;
                case "Ranger":
                    Color1 = RangerColor;
                    break;
                case "Ranger_Raptor":
                    Color1 = RangerRaptorColor;
                    break;
                case "Transit":
                    Color1 = TransitColor;
                    break;
                default:
                    break;
            }
            switch(Color1.Length) 
            {
                case 4:
                    ColorButton5.Visible = false;
                    ColorButton6.Visible = false;
                    ColorButton1.BackColor = Color.FromName(Color1[0].Split("_")[1]);
                    ColorButton2.BackColor = Color.FromName(Color1[1].Split("_")[1]);
                    ColorButton3.BackColor = Color.FromName(Color1[2].Split("_")[1]);
                    ColorButton4.BackColor = Color.FromName(Color1[3].Split("_")[1]);
                    break;
                case 5:
                    ColorButton6.Visible = false;
                    ColorButton1.BackColor = Color.FromName(Color1[0].Split("_")[1]);
                    ColorButton2.BackColor = Color.FromName(Color1[1].Split("_")[1]);
                    ColorButton3.BackColor = Color.FromName(Color1[2].Split("_")[1]);
                    ColorButton4.BackColor = Color.FromName(Color1[3].Split("_")[1]);
                    ColorButton5.BackColor = Color.FromName(Color1[4].Split("_")[1]);
                    break;
                case 6:
                    ColorButton1.BackColor = Color.FromName(Color1[0].Split("_")[1]);
                    ColorButton2.BackColor = Color.FromName(Color1[1].Split("_")[1]);
                    ColorButton3.BackColor = Color.FromName(Color1[2].Split("_")[1]);
                    ColorButton4.BackColor = Color.FromName(Color1[3].Split("_")[1]);
                    ColorButton5.BackColor = Color.FromName(Color1[4].Split("_")[1]);
                    ColorButton6.BackColor = Color.FromName(Color1[5].Split("_")[1]);
                    break;
                default:
                    break;
            }
            // Thay title + đưa hình đại diện ban đầu, mặc định là màu đen
            string tmp = Name1.ToUpper() + Color1[0].ToString();
            CarTypeFormPictureBox.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(tmp.ToString());
            CarTypeNameLabel.Text = FullName1;

            // Đưa tên vào các button làm option
            string FolderName = "";
            switch (Name1)
            {
                case "Everest":
                    FolderName = "FORD EVEREST";
                    break;
                case "Explorer":
                    FolderName = "FORD EXPLORER";
                    break;
                case "Ranger":
                    FolderName = "FORD RANGER";
                    break;
                case "Ranger_Raptor":
                    FolderName = "FORD RANGER RAPTOR";
                    break;
                case "Transit":
                    FolderName = "FORD TRANSIT";
                    break;
                default:
                    break;
            }
            string DataPath = @"D:\Project\CS511\Final2\CS511-Cuoi-ki\resou\Car\" + FolderName + @"\Inform\Name.txt";
            
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            BuyPanel.Visible = true;
        }

        private void BuyPanelExitButton_Click(object sender, EventArgs e)
        {
            BuyPanel.Visible = false;
            CusNameTextBox.Text = "";
            CusAddTextBox.Text = "";
            CusTelTextBox.Text = "";
        }

        private void CusTelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private string CustomGetButtonColor(string a)
        {
            int start = a.IndexOf("[");
            int end = a.IndexOf("]");
            string res = "";
            for(int i = start + 1; i < end; i++)
            {
                res += a[i];
            }
            return res;
        }
        private void ColorButton1_Click(object sender, EventArgs e)
        {
            string tmp = CustomGetButtonColor(ColorButton1.BackColor.ToString());
            string tmp1 = Name.ToUpper() + "_" + tmp.ToUpper();
            CarTypeFormPictureBox.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(tmp1.ToString());
        }

        private void ColorButton2_Click(object sender, EventArgs e)
        {
            string tmp = CustomGetButtonColor(ColorButton2.BackColor.ToString());
            string tmp1 = Name.ToUpper() + "_" + tmp.ToUpper();
            CarTypeFormPictureBox.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(tmp1.ToString());

        }

        private void ColorButton3_Click(object sender, EventArgs e)
        {
            string tmp = CustomGetButtonColor(ColorButton3.BackColor.ToString());
            string tmp1 = Name.ToUpper() + "_" + tmp.ToUpper();
            CarTypeFormPictureBox.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(tmp1.ToString());
        }

        private void ColorButton4_Click(object sender, EventArgs e)
        {
            string tmp = CustomGetButtonColor(ColorButton4.BackColor.ToString());
            string tmp1 = Name.ToUpper() + "_" + tmp.ToUpper();
            CarTypeFormPictureBox.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(tmp1.ToString());
        }

        private void ColorButton5_Click(object sender, EventArgs e)
        {
            string tmp = CustomGetButtonColor(ColorButton5.BackColor.ToString());
            string tmp1 = Name.ToUpper() + "_" + tmp.ToUpper();
            CarTypeFormPictureBox.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(tmp1.ToString());
        }

        private void ColorButton6_Click(object sender, EventArgs e)
        {
            string tmp = CustomGetButtonColor(ColorButton6.BackColor.ToString());
            string tmp1 = Name.ToUpper() + "_" + tmp.ToUpper();
            CarTypeFormPictureBox.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(tmp1.ToString());
        }

        private void CusNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
