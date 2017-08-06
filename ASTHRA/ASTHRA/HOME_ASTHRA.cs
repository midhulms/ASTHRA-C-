using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASTHRA
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Documenthide_ASTHRA open = new Documenthide_ASTHRA();
            open.Show();
            this.Hide();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Texthide_ASTHRA open = new Texthide_ASTHRA();
            open.Show();
            this.Hide();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

      
    }
}
