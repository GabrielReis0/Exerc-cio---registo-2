using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Exercício___registo_2
{
    public partial class Form2 : Form
    {
        private List<Utilizador> utilizadores;
        public Form2(List<Utilizador> utilizadores)
        {
            InitializeComponent();
            this.utilizadores = utilizadores;   
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Utilizador util in utilizadores)
            {
                listBoxUtilizadores.Items.Add(util.Nome);
            }
        }
    }
}
