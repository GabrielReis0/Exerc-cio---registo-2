using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Exercício___registo_2
{
    public partial class Form1 : Form
    {
        private List<Utilizador> utilizadores = new List<Utilizador>();
        public Form1()
        {
            InitializeComponent();
        }

        public void btnguardarregisto_Click(object sender, EventArgs e)
        {
            Utilizador novoUtilizador = new Utilizador ();
            
            Utilizador.Nome = txtNome.Text;
            Utilizador.Email = txtGmail.Text;
            Utilizador.Password = txtPassword.Text;

            utilizadores.Add(novoUtilizador);

            MessageBox.Show("Utilizador Registado!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
 

            txtNome.Clear();
            txtGmail.Clear();
            txtPassword.Clear();
        }

        public void checkBoxpassword_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxpassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }

        }

        public void btntodosregistos_Click(object sender, EventArgs e)
        { 
            this.Hide();
            this.Show();
        }
    }
}