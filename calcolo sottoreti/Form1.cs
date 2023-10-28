using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace calcolo_sottoreti
{
    public partial class Form1 : Form
    {
        public string classe;
        public int bitrete;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calcola_Click(object sender, EventArgs e)
        {
            
            if (Math.Log(int.Parse(Sottoreti.Text), 2) + Math.Log(int.Parse(Host.Text) + 2, 2) <= 8)
            {
                classe = "C";
            }
            else if (Math.Log(int.Parse(Sottoreti.Text), 2) + Math.Log(int.Parse(Host.Text) + 2, 2) <= 16)
            {
                classe = "B";
            }
            else if (Math.Log(int.Parse(Sottoreti.Text), 2) + Math.Log(int.Parse(Host.Text) + 2, 2) <= 24)
            {
                classe = "A";
            }
            else
            {
                MessageBox.Show("Esagera mia");
            }
            Class.Text = classe;
            if (Class.Text == "A")
            {
                Indirizzoprivato.Text = "10.0.0.0";
                bitrete = 8;
            }
            if (Class.Text == "B")
            {
                Indirizzoprivato.Text = "172.16.0.0";
                bitrete = 16;
            }
            if (Class.Text == "C")
            {
                Indirizzoprivato.Text = "192.168.0.0";
                bitrete = 24;
            }

        }
        public int subnetmask()
        {
            int esponente = 0;
            int ultimobit;
            double lasub = 0;
            while (int.Parse(Sottoreti.Text)<=Math.Pow(2,esponente))
            {
                esponente++;
            }
            if (Class.Text == "A")
            {
                Indirizzoprivato.Text = "10.0.0.0";
                bitrete = 8 + esponente;
            }
            if (Class.Text == "B")
            {
                Indirizzoprivato.Text = "172.16.0.0";
                bitrete = 16 + esponente;
            }
            if (Class.Text == "C")
            {
                Indirizzoprivato.Text = "192.168.0.0";
                bitrete = 24 + esponente;
            }
            ultimobit -= esponente;
            for (int i=ultimobit; i>=0; i++) 
            {
                lasub += Math.Pow(2, i);
            }
            return bitrete;
        }
    }
}
