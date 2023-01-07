using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class humaniodDD : Form
    {
        DD newDD;
        public humaniodDD()
        {
            newDD = new DD();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            newDD.snore();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 back = new Form2();
            back.Show();
        }
    }
}
