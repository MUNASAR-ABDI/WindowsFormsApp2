using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        int characterSld = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            characterSld = 1;//YY
            characterchng();
            var humanoidYY= new humanoidYY();
            humanoidYY.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            characterSld = 2;//ZZ
            characterchng();
            var humanoidZZ = new HumanoidZZ();
            humanoidZZ.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            characterSld = 3;//NN
            characterchng();
            var humanoidNN = new humanoidNN();
            humanoidNN.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            characterSld = 4;//DD
            characterchng();
            var humanoidNN = new humaniodDD();
            humanoidNN.Show();
            this.Hide();
        }
        void characterchng()
        {
            if (characterSld == 1)//YY
            {
                pictureBox2.BackColor = Color.LightCyan;
                pictureBox1.BackColor = Color.LightCyan;
                pictureBox3.BackColor = Color.LightCyan;
                pictureBox4.BackColor = Color.LightCyan;

                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                pictureBox2.BorderStyle = BorderStyle.Fixed3D;
                pictureBox3.BorderStyle = BorderStyle.FixedSingle;
                pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            }
             else if (characterSld == 2)//ZZ
            {
                pictureBox2.BackColor = Color.LightCyan;
                pictureBox1.BackColor = Color.LightCyan;
                pictureBox3.BackColor = Color.LightCyan;
                pictureBox4.BackColor = Color.LightCyan;

                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                pictureBox2.BorderStyle = BorderStyle.FixedSingle;
                pictureBox3.BorderStyle = BorderStyle.FixedSingle;
                pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            }
            else if (characterSld == 3)//NN
            {
                pictureBox2.BackColor = Color.LightCyan;
                pictureBox1.BackColor = Color.LightCyan;
                pictureBox3.BackColor = Color.LightCyan;
                pictureBox4.BackColor = Color.LightCyan;

                pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                pictureBox2.BorderStyle = BorderStyle.FixedSingle;
                pictureBox3.BorderStyle = BorderStyle.FixedSingle;
                pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (characterSld == 4)//DD
            {
                pictureBox2.BackColor = Color.LightCyan;
                pictureBox1.BackColor = Color.LightCyan;
                pictureBox3.BackColor = Color.LightCyan;
                pictureBox4.BackColor = Color.LightCyan;

                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                pictureBox2.BorderStyle = BorderStyle.FixedSingle;
                pictureBox3.BorderStyle = BorderStyle.Fixed3D;
                pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var uml= new uml();
            uml.Show();
        }
    }
}
