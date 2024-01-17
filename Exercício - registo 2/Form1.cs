using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Exercício___registo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnguardarregisto_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            string email = txtGmail.Text;
            string password = txtPassword.Text;

            if (nome == "" && email == "" && password == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nome == "" && email == "")
            {
                MessageBox.Show("Por favor, preencha o Nome e Email.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (nome == "" && password == "")
            {
                MessageBox.Show("Por favor, preencha o Nome e Password.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (email == "" && password == "")
            {
                MessageBox.Show("Por favor, preencha o Email e Password.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (nome == "")
            {
                MessageBox.Show("Por favor, preencha o Nome.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (email == "")
            {
                MessageBox.Show("Por favor, preencha o Email.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (password == "")
            {
                MessageBox.Show("Por favor, preencha a Password.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Utilizador.Registar(nome, email, password);

                MessageBox.Show("Utilizador Registado!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Clear();
                txtGmail.Clear();
                txtPassword.Clear();

            }
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
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Show();
        }
    }
}