namespace app1Aleluya
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.previewImgAleluya = new System.Windows.Forms.PictureBox();
            this.inputImageAleluya = new System.Windows.Forms.TextBox();
            this.selectInputImageBtnAleluya = new System.Windows.Forms.Button();
            this.passwordAleluya = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.decodeImageBtnAleluya = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.encodeBtnAleluya = new System.Windows.Forms.Button();
            this.inputDataAleluya = new System.Windows.Forms.TextBox();
            this.selectInputDataAleluya = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.decodeImgBtnAleluya = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewImgAleluya)).BeginInit();
            this.decodeImageBtnAleluya.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jesus Christ is coming soon";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // previewImgAleluya
            // 
            this.previewImgAleluya.Image = global::app1Aleluya.Properties.Resources.king_james_bible;
            this.previewImgAleluya.Location = new System.Drawing.Point(361, 45);
            this.previewImgAleluya.Name = "previewImgAleluya";
            this.previewImgAleluya.Size = new System.Drawing.Size(312, 229);
            this.previewImgAleluya.TabIndex = 1;
            this.previewImgAleluya.TabStop = false;
            // 
            // inputImageAleluya
            // 
            this.inputImageAleluya.Enabled = false;
            this.inputImageAleluya.Location = new System.Drawing.Point(156, 82);
            this.inputImageAleluya.Name = "inputImageAleluya";
            this.inputImageAleluya.Size = new System.Drawing.Size(166, 20);
            this.inputImageAleluya.TabIndex = 2;
            this.inputImageAleluya.Click += new System.EventHandler(this.inputImageAleluya_Click);
            // 
            // selectInputImageBtnAleluya
            // 
            this.selectInputImageBtnAleluya.Location = new System.Drawing.Point(16, 80);
            this.selectInputImageBtnAleluya.Name = "selectInputImageBtnAleluya";
            this.selectInputImageBtnAleluya.Size = new System.Drawing.Size(134, 23);
            this.selectInputImageBtnAleluya.TabIndex = 4;
            this.selectInputImageBtnAleluya.Text = "Select Image - Hallelujah";
            this.selectInputImageBtnAleluya.UseVisualStyleBackColor = true;
            this.selectInputImageBtnAleluya.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordAleluya
            // 
            this.passwordAleluya.Location = new System.Drawing.Point(130, 165);
            this.passwordAleluya.Name = "passwordAleluya";
            this.passwordAleluya.PasswordChar = '*';
            this.passwordAleluya.Size = new System.Drawing.Size(196, 20);
            this.passwordAleluya.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password - Hallelujah";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // decodeImageBtnAleluya
            // 
            this.decodeImageBtnAleluya.Controls.Add(this.tabPage1);
            this.decodeImageBtnAleluya.Controls.Add(this.tabPage2);
            this.decodeImageBtnAleluya.Location = new System.Drawing.Point(15, 237);
            this.decodeImageBtnAleluya.Name = "decodeImageBtnAleluya";
            this.decodeImageBtnAleluya.SelectedIndex = 0;
            this.decodeImageBtnAleluya.Size = new System.Drawing.Size(318, 131);
            this.decodeImageBtnAleluya.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.encodeBtnAleluya);
            this.tabPage1.Controls.Add(this.inputDataAleluya);
            this.tabPage1.Controls.Add(this.selectInputDataAleluya);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(310, 105);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encode File into Image Aleluya";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // encodeBtnAleluya
            // 
            this.encodeBtnAleluya.Location = new System.Drawing.Point(10, 74);
            this.encodeBtnAleluya.Name = "encodeBtnAleluya";
            this.encodeBtnAleluya.Size = new System.Drawing.Size(285, 23);
            this.encodeBtnAleluya.TabIndex = 3;
            this.encodeBtnAleluya.Text = "Step 5) Go - then choose target file - Aleluya";
            this.encodeBtnAleluya.UseVisualStyleBackColor = true;
            this.encodeBtnAleluya.Click += new System.EventHandler(this.encodeBtnAleluya_Click);
            // 
            // inputDataAleluya
            // 
            this.inputDataAleluya.Enabled = false;
            this.inputDataAleluya.Location = new System.Drawing.Point(153, 36);
            this.inputDataAleluya.Name = "inputDataAleluya";
            this.inputDataAleluya.Size = new System.Drawing.Size(142, 20);
            this.inputDataAleluya.TabIndex = 2;
            this.inputDataAleluya.Click += new System.EventHandler(this.inputDataAleluya_Click);
            // 
            // selectInputDataAleluya
            // 
            this.selectInputDataAleluya.Location = new System.Drawing.Point(11, 33);
            this.selectInputDataAleluya.Name = "selectInputDataAleluya";
            this.selectInputDataAleluya.Size = new System.Drawing.Size(136, 23);
            this.selectInputDataAleluya.TabIndex = 1;
            this.selectInputDataAleluya.Text = "File to Cypher - Aleluya";
            this.selectInputDataAleluya.UseVisualStyleBackColor = true;
            this.selectInputDataAleluya.Click += new System.EventHandler(this.selectInputDataAleluya_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.decodeImgBtnAleluya);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(310, 105);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decode Data in Image Aleluya";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // decodeImgBtnAleluya
            // 
            this.decodeImgBtnAleluya.Location = new System.Drawing.Point(9, 17);
            this.decodeImgBtnAleluya.Name = "decodeImgBtnAleluya";
            this.decodeImgBtnAleluya.Size = new System.Drawing.Size(280, 70);
            this.decodeImgBtnAleluya.TabIndex = 0;
            this.decodeImgBtnAleluya.Text = "Step 4) Go - then choose destination file - Aleluya";
            this.decodeImgBtnAleluya.UseVisualStyleBackColor = true;
            this.decodeImgBtnAleluya.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "The Name of the Lord be Praised :D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Step 1) Select Image to Encode/Decode, Aleluya";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Recommended a png with no fully transparent or large uniform colors";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(319, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Better security with at least 12 random characters and don\'t lose it.";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(339, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Step 2) Enter the Encryption/Decryption key, Aleluya";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Thank You Lord Jesus for dearly beloved Hannah and Ian";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(298, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Step 3) Choose to Encrypt or Decrypt, Aleluya";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Step 4) Choose File to Encrypt, Aleluya";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(435, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(160, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Watch the Jesus Film, Hallelujah";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(358, 277);
            this.label11.MaximumSize = new System.Drawing.Size(320, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(316, 65);
            this.label11.TabIndex = 17;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 390);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decodeImageBtnAleluya);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordAleluya);
            this.Controls.Add(this.selectInputImageBtnAleluya);
            this.Controls.Add(this.inputImageAleluya);
            this.Controls.Add(this.previewImgAleluya);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hallelujah";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previewImgAleluya)).EndInit();
            this.decodeImageBtnAleluya.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox previewImgAleluya;
        private System.Windows.Forms.TextBox inputImageAleluya;
        private System.Windows.Forms.Button selectInputImageBtnAleluya;
        private System.Windows.Forms.TextBox passwordAleluya;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl decodeImageBtnAleluya;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button encodeBtnAleluya;
        private System.Windows.Forms.TextBox inputDataAleluya;
        private System.Windows.Forms.Button selectInputDataAleluya;
        private System.Windows.Forms.Button decodeImgBtnAleluya;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label11;
    }
}

