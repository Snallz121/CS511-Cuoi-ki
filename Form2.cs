using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
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
        string FolderName = "";
        string StandForCarName = "";

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
                    StandForCarName = "RE";
                    break;
                case "Explorer":
                    Color1 = ExplorerColor;
                    StandForCarName = "REx";
                    break;
                case "Ranger":
                    Color1 = RangerColor;
                    StandForCarName = "RR";
                    break;
                case "Ranger_Raptor":
                    Color1 = RangerRaptorColor;
                    StandForCarName = "RRR";
                    break;
                case "Transit":
                    Color1 = TransitColor;
                    StandForCarName = "None";
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
            var textfile = File.ReadAllText(DataPath);
            string[] filestrings = textfile.Split("\n");
            switch(filestrings.Length)
            {
                case 1:
                    EngineButton1.Text = filestrings[0];
                    EngineButton2.Visible = false;
                    EngineButton3.Visible = false;
                    EngineButton4.Visible = false;
                    EngineButton5.Visible = false;
                    EngineButton6.Visible = false;
                    break;
                case 4:
                    EngineButton1.Text = filestrings[0];
                    EngineButton2.Text = filestrings[1];
                    EngineButton4.Text = filestrings[2];
                    EngineButton5.Text = filestrings[3];
                    EngineButton3.Visible = false;
                    EngineButton6.Visible = false;
                    break;
                case 6:
                    EngineButton1.Text = filestrings[0];
                    EngineButton2.Text = filestrings[1];
                    EngineButton3.Text = filestrings[2];
                    EngineButton4.Text = filestrings[3];
                    EngineButton5.Text = filestrings[4];
                    EngineButton6.Text = filestrings[5];
                    break;
            }
            //Doc file text mo ta dong co
            string DataPath1 = @"D:\Project\CS511\Final2\CS511-Cuoi-ki\resou\Car\" + FolderName + @"\Inform\" + filestrings[0].Trim() + ".txt";
            var Engine1 = File.ReadAllText(DataPath1);
            EngineDesTextBox.Text = Engine1;
            //Setting gia niem yet ban dau
            string DataPath2 = @"D:\Project\CS511\Final2\CS511-Cuoi-ki\resou\Car\" + FolderName + @"\Inform\Price.txt";
            var Price = File.ReadAllText(DataPath2);
            MoneyLabel.Text = Price.Split("\n")[0].Trim() + " VNĐ";
            // Setting hinh anh thuc te

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

        private void EngineTextChange(string name)
        {
            // Engine description
            string DataPath1 = @"D:\Project\CS511\Final2\CS511-Cuoi-ki\resou\Car\" + FolderName + @"\Inform\" + name.Trim() + ".txt";
            var EngineText = File.ReadAllText(DataPath1);
            EngineDesTextBox.Text = EngineText;
            // Gia tien
            string DataPath2 = @"D:\Project\CS511\Final2\CS511-Cuoi-ki\resou\Car\" + FolderName + @"\Inform\Name.txt";
            var Price = File.ReadAllText(DataPath2);
            string[] tmpNameArr = Price.Split("\n");
            int pos = 0;
            for(int i = 0; i < tmpNameArr.Length; i++)
            {
                //MessageBox.Show(tmpNameArr[i].Trim() + "\n" + name);
                if (tmpNameArr[i].Trim() == name.Trim())
                {
                    pos = i;
                    break;
                }
                else pos = -1;
            }
            string DataPath3 = @"D:\Project\CS511\Final2\CS511-Cuoi-ki\resou\Car\" + FolderName + @"\Inform\Price.txt";
            MoneyLabel.Text = File.ReadAllText(DataPath3).Split("\n")[pos].Trim() + " VNĐ";
        }
        private void EngineButton1_Click(object sender, EventArgs e)
        {
            EngineTextChange(EngineButton1.Text);
        }

        private void EngineButton2_Click(object sender, EventArgs e)
        {
            EngineTextChange(EngineButton2.Text);
        }

        private void EngineButton3_Click(object sender, EventArgs e)
        {
            EngineTextChange(EngineButton3.Text);

        }

        private void EngineButton4_Click(object sender, EventArgs e)
        {
            EngineTextChange(EngineButton4.Text);

        }

        private void EngineButton5_Click(object sender, EventArgs e)
        {
            EngineTextChange(EngineButton5.Text);
        }

        private void EngineButton6_Click(object sender, EventArgs e)
        {
            EngineTextChange(EngineButton6.Text);
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
