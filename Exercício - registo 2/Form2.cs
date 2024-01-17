using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Exercício___registo_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        public void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Utilizador utilizador in Utilizador.listautilizadores) 
            {
                listBox1.Items.Add(utilizador.Nome);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
