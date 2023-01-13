namespace Ford_Showroom
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.BackgroundImage = global::Ford_Showroom.Properties.Resources.REx1;
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox.Location = new System.Drawing.Point(490, 64);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(729, 729);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = global::Ford_Showroom.Properties.Resources.redExit;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.Location = new System.Drawing.Point(1215, 35);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(35, 34);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Silver;
            this.NextButton.BackgroundImage = global::Ford_Showroom.Properties.Resources.next;
            this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextButton.Location = new System.Drawing.Point(1446, 360);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(63, 61);
            this.NextButton.TabIndex = 2;
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Silver;
            this.BackButton.BackgroundImage = global::Ford_Showroom.Properties.Resources.back;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Location = new System.Drawing.Point(209, 360);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(63, 61);
            this.BackButton.TabIndex = 3;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Showroom App";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PictureBox;
        private Button ExitButton;
        private Button NextButton;
        private Button BackButton;
    }
}