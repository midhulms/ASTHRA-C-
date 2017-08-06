namespace ASTHRA
{
    partial class Home
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
            this.document = new System.Windows.Forms.Button();
            this.TEXT = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // document
            // 
            this.document.BackgroundImage = global::ASTHRA.Properties.Resources.doc_flat_1_;
            this.document.Location = new System.Drawing.Point(47, 440);
            this.document.Name = "document";
            this.document.Size = new System.Drawing.Size(105, 104);
            this.document.TabIndex = 0;
            this.document.UseVisualStyleBackColor = true;
            this.document.Click += new System.EventHandler(this.button1_Click);
            // 
            // TEXT
            // 
            this.TEXT.BackgroundImage = global::ASTHRA.Properties.Resources.txt_flat_1_;
            this.TEXT.Location = new System.Drawing.Point(47, 248);
            this.TEXT.Name = "TEXT";
            this.TEXT.Size = new System.Drawing.Size(105, 104);
            this.TEXT.TabIndex = 1;
            this.TEXT.UseVisualStyleBackColor = true;
            this.TEXT.Click += new System.EventHandler(this.button2_Click);
            // 
            // close
            // 
            this.close.BackgroundImage = global::ASTHRA.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(963, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(35, 33);
            this.close.TabIndex = 2;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.button3_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ASTHRA.Properties.Resources.step0004;
            this.ClientSize = new System.Drawing.Size(992, 690);
            this.Controls.Add(this.close);
            this.Controls.Add(this.TEXT);
            this.Controls.Add(this.document);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button document;
        private System.Windows.Forms.Button TEXT;
        private System.Windows.Forms.Button close;
    }
}

