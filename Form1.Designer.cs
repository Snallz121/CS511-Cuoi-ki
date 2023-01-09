namespace Ford_Showroom
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.HomeButton = new System.Windows.Forms.Button();
            this.CarTypeButton = new System.Windows.Forms.Button();
            this.ServiceButton = new System.Windows.Forms.Button();
            this.PriceBoardButton = new System.Windows.Forms.Button();
            this.ContactInfoButton = new System.Windows.Forms.Button();
            this.MainFormCarPictureBox = new System.Windows.Forms.PictureBox();
            this.MainFormCarPictureBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.CarTypePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormCarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.Location = new System.Drawing.Point(150, 173);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(190, 77);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Trang chủ";
            this.HomeButton.UseVisualStyleBackColor = false;
            // 
            // CarTypeButton
            // 
            this.CarTypeButton.BackColor = System.Drawing.Color.Transparent;
            this.CarTypeButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CarTypeButton.Location = new System.Drawing.Point(414, 173);
            this.CarTypeButton.Name = "CarTypeButton";
            this.CarTypeButton.Size = new System.Drawing.Size(190, 77);
            this.CarTypeButton.TabIndex = 1;
            this.CarTypeButton.Text = "Các loại xe";
            this.CarTypeButton.UseVisualStyleBackColor = false;
            // 
            // ServiceButton
            // 
            this.ServiceButton.BackColor = System.Drawing.Color.Transparent;
            this.ServiceButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ServiceButton.Location = new System.Drawing.Point(678, 173);
            this.ServiceButton.Name = "ServiceButton";
            this.ServiceButton.Size = new System.Drawing.Size(190, 77);
            this.ServiceButton.TabIndex = 2;
            this.ServiceButton.Text = "Dịch vụ";
            this.ServiceButton.UseVisualStyleBackColor = false;
            // 
            // PriceBoardButton
            // 
            this.PriceBoardButton.BackColor = System.Drawing.Color.Transparent;
            this.PriceBoardButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriceBoardButton.Location = new System.Drawing.Point(942, 173);
            this.PriceBoardButton.Name = "PriceBoardButton";
            this.PriceBoardButton.Size = new System.Drawing.Size(190, 77);
            this.PriceBoardButton.TabIndex = 3;
            this.PriceBoardButton.Text = "Bảng giá";
            this.PriceBoardButton.UseVisualStyleBackColor = false;
            // 
            // ContactInfoButton
            // 
            this.ContactInfoButton.BackColor = System.Drawing.Color.Transparent;
            this.ContactInfoButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactInfoButton.Location = new System.Drawing.Point(1206, 173);
            this.ContactInfoButton.Name = "ContactInfoButton";
            this.ContactInfoButton.Size = new System.Drawing.Size(190, 77);
            this.ContactInfoButton.TabIndex = 4;
            this.ContactInfoButton.Text = "Liên hệ";
            this.ContactInfoButton.UseVisualStyleBackColor = false;
            // 
            // MainFormCarPictureBox
            // 
            this.MainFormCarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainFormCarPictureBox.Location = new System.Drawing.Point(0, 247);
            this.MainFormCarPictureBox.Name = "MainFormCarPictureBox";
            this.MainFormCarPictureBox.Size = new System.Drawing.Size(1578, 474);
            this.MainFormCarPictureBox.TabIndex = 5;
            this.MainFormCarPictureBox.TabStop = false;
            // 
            // MainFormCarPictureBoxTimer
            // 
            this.MainFormCarPictureBoxTimer.Interval = 3000;
            this.MainFormCarPictureBoxTimer.Tick += new System.EventHandler(this.MainFormCarPictureBoxTimer_Tick);
            // 
            // CarTypePanel
            // 
            this.CarTypePanel.Location = new System.Drawing.Point(0, 247);
            this.CarTypePanel.Name = "CarTypePanel";
            this.CarTypePanel.Size = new System.Drawing.Size(1578, 596);
            this.CarTypePanel.TabIndex = 6;
            this.CarTypePanel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ford_Showroom.Properties.Resources.Home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.CarTypePanel);
            this.Controls.Add(this.MainFormCarPictureBox);
            this.Controls.Add(this.ContactInfoButton);
            this.Controls.Add(this.PriceBoardButton);
            this.Controls.Add(this.ServiceButton);
            this.Controls.Add(this.CarTypeButton);
            this.Controls.Add(this.HomeButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Showroom App";
            ((System.ComponentModel.ISupportInitialize)(this.MainFormCarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button HomeButton;
        private Button CarTypeButton;
        private Button ServiceButton;
        private Button PriceBoardButton;
        private Button ContactInfoButton;
        private PictureBox MainFormCarPictureBox;
        private System.Windows.Forms.Timer MainFormCarPictureBoxTimer;
        private Panel CarTypePanel;
    }
}