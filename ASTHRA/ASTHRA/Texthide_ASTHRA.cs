using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.IO;
using Steganography;

namespace ASTHRA
{
    public partial class Texthide_ASTHRA : Form
    {
        public Texthide_ASTHRA()
        {
            InitializeComponent();
        }
        Bitmap image = null;
       
        string extractedText = string.Empty;
       
private void imageToolStripMenuItem1_Click(object sender, EventArgs e)
       {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
               imagePictureBox.Image = Image.FromFile(open_dialog.FileName);
            }
        }
      
        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
           SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
               switch (save_dialog.FilterIndex)
              {
                   case 0:
                       {
                           image.Save(save_dialog.FileName, ImageFormat.Png);
                        } break;
                   case 1:
                       {
                           image.Save(save_dialog.FileName, ImageFormat.Bmp);
                       } break;
               }

               notesLabel.Text = "Notes:";
               notesLabel.ForeColor = Color.Black;
            }
       }
       
        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
           SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Text Files|*.txt";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save_dialog.FileName, dataTextBox.Text);
            }
        }

        

        private void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
           open_dialog.Filter = "Text Files|*.txt";
    
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
               dataTextBox.Text = File.ReadAllText(open_dialog.FileName);
            }
        }




        private void passwordTextBox_TextChanged_1(object sender, EventArgs e)
        {
           

            passwordTextBox.PasswordChar = '*';
           
          
        }

        private void selectimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (opendialog.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = Image.FromFile(opendialog.FileName);
            }
        }

      

        private void imagePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void selecttext_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Text Files|*.txt";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                dataTextBox.Text = File.ReadAllText(open_dialog.FileName);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            image = (Bitmap)imagePictureBox.Image;

            string extractedText = lsb_ASTHRA.extractText(image);

            if (encryptCheckBox.Checked)
            {
                try
                {
                    extractedText = AESencrypt_ASTHRA.DecryptStringAES(extractedText, passwordTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Wrong password", "Error");

                    return;
                }
            }
            
            dataTextBox.Text = extractedText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                switch (save_dialog.FilterIndex)
                {
                    case 0:
                        {
                            image.Save(save_dialog.FileName, ImageFormat.Png);
                        } break;
                    case 1:
                        {
                            image.Save(save_dialog.FileName, ImageFormat.Bmp);
                        } break;
                }

                notesLabel.Text = "Notes:";
                notesLabel.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

              saveFileDialog1.InitialDirectory = @"C:\Users\midhul\Desktop";

            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            saveFileDialog1.FilterIndex = 2;

   



            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    sw.WriteLine(dataTextBox.Text);

                dataTextBox.Text = saveFileDialog1.FileName;

            }
  

        }

        private void encryptCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

      
        private void HIDEBUTTON_Click_1(object sender, EventArgs e)
        {
            image = (Bitmap)imagePictureBox.Image;

            string text = dataTextBox.Text;

            if (text.Equals(""))
            {
                MessageBox.Show("The text you want to hide can't be empty", "Warning");

                return;
            }

            if (encryptCheckBox.Checked)
            {
                if (passwordTextBox.Text.Length < 4)
                {
                    MessageBox.Show("Please enter a password with at least 4 characters", "Warning");

                    return;
                }
                else
                {
                    text = AESencrypt_ASTHRA.EncryptStrAES(text, passwordTextBox.Text);
                }
            }

            image = lsb_ASTHRA.HideText(text, image);

            MessageBox.Show("Your text was hidden in the image successfully!", "Done");

            notesLabel.Text = "Notes: don't forget to save your new image.";
            notesLabel.ForeColor = Color.OrangeRed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            Home mk = new Home();
            mk.Show();
            Close();
        }

        private void Text_Load(object sender, EventArgs e)
        {

        }

       
       
    }
}
