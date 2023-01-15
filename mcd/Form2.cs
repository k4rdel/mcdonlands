using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace mcd
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        public void Wyswietlanie(int ktory)
        {
            string linie = File.ReadAllText(@"potrawy.txt");
            string[] parts = linie.Split(';');
            Potrawa Burgery = new Potrawa(parts[0 + (3 * ktory)], parts[1 + (3 * ktory)], "\nCena: " + parts[2 + (3 * ktory)] + "zł");
            Burgery.Wyswietl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wyswietlanie(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wyswietlanie(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wyswietlanie(2);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Wyswietlanie(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Wyswietlanie(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Wyswietlanie(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Wyswietlanie(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Wyswietlanie(7);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close"))
                Application.Exit();
            else
                Application.Exit();
        }
    }
}
