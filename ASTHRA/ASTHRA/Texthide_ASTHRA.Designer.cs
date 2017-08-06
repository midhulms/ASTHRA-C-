namespace ASTHRA
{
    partial class Texthide_ASTHRA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Texthide_ASTHRA));
            this.selectimage = new System.Windows.Forms.Button();
            this.selecttext = new System.Windows.Forms.Button();
            this.encryptCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.dataTextBox = new System.Windows.Forms.RichTextBox();
            this.saveimage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.HIDEBUTTON = new System.Windows.Forms.Button();
            this.extract = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // selectimage
            // 
            this.selectimage.BackgroundImage = global::ASTHRA.Properties.Resources.imagw_1_;
            this.selectimage.Location = new System.Drawing.Point(51, 72);
            this.selectimage.Name = "selectimage";
            this.selectimage.Size = new System.Drawing.Size(73, 70);
            this.selectimage.TabIndex = 0;
            this.selectimage.UseVisualStyleBackColor = true;
            this.selectimage.Click += new System.EventHandler(this.selectimage_Click);
            // 
            // selecttext
            // 
            this.selecttext.BackgroundImage = global::ASTHRA.Properties.Resources.text1;
            this.selecttext.Location = new System.Drawing.Point(248, 72);
            this.selecttext.Name = "selecttext";
            this.selecttext.Size = new System.Drawing.Size(73, 70);
            this.selecttext.TabIndex = 1;
            this.selecttext.UseVisualStyleBackColor = true;
            this.selecttext.Click += new System.EventHandler(this.selecttext_Click);
            // 
            // encryptCheckBox
            // 
            this.encryptCheckBox.AutoSize = true;
            this.encryptCheckBox.Location = new System.Drawing.Point(397, 92);
            this.encryptCheckBox.Name = "encryptCheckBox";
            this.encryptCheckBox.Size = new System.Drawing.Size(15, 14);
            this.encryptCheckBox.TabIndex = 2;
            this.encryptCheckBox.UseVisualStyleBackColor = true;
            this.encryptCheckBox.CheckedChanged += new System.EventHandler(this.encryptCheckBox_CheckedChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(545, 84);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(164, 22);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged_1);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Location = new System.Drawing.Point(12, 176);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(561, 398);
            this.imagePictureBox.TabIndex = 4;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.Click += new System.EventHandler(this.imagePictureBox_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(601, 167);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(417, 387);
            this.dataTextBox.TabIndex = 5;
            this.dataTextBox.Text = "";
            this.dataTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // saveimage
            // 
            this.saveimage.BackgroundImage = global::ASTHRA.Properties.Resources.FontAwesome_f0c7_0__64;
            this.saveimage.Location = new System.Drawing.Point(87, 591);
            this.saveimage.Name = "saveimage";
            this.saveimage.Size = new System.Drawing.Size(64, 66);
            this.saveimage.TabIndex = 10;
            this.saveimage.UseVisualStyleBackColor = true;
            this.saveimage.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ASTHRA.Properties.Resources.FontAwesome_f0c7_0__64;
            this.button2.Location = new System.Drawing.Point(961, 579);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 66);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HIDEBUTTON
            // 
            this.HIDEBUTTON.BackgroundImage = global::ASTHRA.Properties.Resources.button_2_;
            this.HIDEBUTTON.Location = new System.Drawing.Point(678, 560);
            this.HIDEBUTTON.Name = "HIDEBUTTON";
            this.HIDEBUTTON.Size = new System.Drawing.Size(80, 30);
            this.HIDEBUTTON.TabIndex = 16;
            this.HIDEBUTTON.UseVisualStyleBackColor = true;
            this.HIDEBUTTON.Click += new System.EventHandler(this.HIDEBUTTON_Click_1);
            // 
            // extract
            // 
            this.extract.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("extract.BackgroundImage")));
            this.extract.Location = new System.Drawing.Point(814, 560);
            this.extract.Name = "extract";
            this.extract.Size = new System.Drawing.Size(75, 30);
            this.extract.TabIndex = 17;
            this.extract.UseVisualStyleBackColor = true;
            this.extract.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 631);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 14);
            this.label7.TabIndex = 18;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.ForeColor = System.Drawing.Color.Tomato;
            this.notesLabel.Location = new System.Drawing.Point(193, 591);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(62, 21);
            this.notesLabel.TabIndex = 19;
            this.notesLabel.Text = "notes";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ASTHRA.Properties.Resources.docclose;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(1025, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 33);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Text
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ASTHRA.Properties.Resources.make;
            this.ClientSize = new System.Drawing.Size(1057, 711);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.extract);
            this.Controls.Add(this.HIDEBUTTON);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveimage);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.encryptCheckBox);
            this.Controls.Add(this.selecttext);
            this.Controls.Add(this.selectimage);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Text";
            this.Text = "Text Hide";
            this.Load += new System.EventHandler(this.Text_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectimage;
        private System.Windows.Forms.Button selecttext;
        private System.Windows.Forms.CheckBox encryptCheckBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.RichTextBox dataTextBox;
        private System.Windows.Forms.Button saveimage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button HIDEBUTTON;
        private System.Windows.Forms.Button extract;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button3;
    }
}