using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int __horseleft1, __horseleft2, __horseleft3;
        int __horsewidth1, __horsewidth2, __horsewidth3;
        int __endwidth;
        Random __random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            //başlangıçta sola olan uzaklığın değeri
            __horseleft1 = pictureBox1.Left;
            __horseleft2 = pictureBox2.Left;
            __horseleft3 = pictureBox3.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //int değişkene genişlik değeri atama
            __horsewidth1 = pictureBox1.Width;
            __horsewidth2 = pictureBox2.Width;
            __horsewidth3 = pictureBox3.Width;

            //label5 olan uzaklık
            __endwidth = label5.Left;

            //resimlerin random değer oluşturması 5-15 arası
            pictureBox1.Left = pictureBox1.Left + __random.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + __random.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + __random.Next(5, 15);

            //Canlı Anlatım
            if(pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "1.At Önde Gidiyor";
            }
            if(pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "2.At İyi bir Atak İle yarışı önde götürüyor";
            }
            if(pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "3.At öne geçti Müthiş bir yarış devam ediyor";
            }
            
           
            //hangi at kazandı kontrolü
            if(__horsewidth1 + pictureBox1.Left >= __endwidth)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 Numaralı AT Kazandı");
            }
            if(__horsewidth2 + pictureBox2.Left >= __endwidth)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 Numaralı AT Kazandı");
            }
            if(__horsewidth3 + pictureBox3.Left >= __endwidth)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 Numaralı AT Kazandı");
            }
        }

        
    }
}
