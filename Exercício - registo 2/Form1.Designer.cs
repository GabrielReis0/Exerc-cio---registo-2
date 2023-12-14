namespace Exercício___registo_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nome = new Label();
            Gmail = new Label();
            Password = new Label();
            btnguardarregisto = new Button();
            btntodosregistos = new Button();
            checkBoxpassword = new CheckBox();
            txtNome = new TextBox();
            txtGmail = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Nome.Location = new Point(323, 68);
            Nome.Name = "Nome";
            Nome.Size = new Size(56, 21);
            Nome.TabIndex = 0;
            Nome.Text = "Nome:";
            // 
            // Gmail
            // 
            Gmail.AutoSize = true;
            Gmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Gmail.Location = new Point(323, 124);
            Gmail.Name = "Gmail";
            Gmail.Size = new Size(54, 21);
            Gmail.TabIndex = 1;
            Gmail.Text = "Gmail:";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password.Location = new Point(323, 190);
            Password.Name = "Password";
            Password.Size = new Size(79, 21);
            Password.TabIndex = 2;
            Password.Text = "Password:";
            // 
            // btnguardarregisto
            // 
            btnguardarregisto.Location = new Point(323, 257);
            btnguardarregisto.Name = "btnguardarregisto";
            btnguardarregisto.Size = new Size(181, 99);
            btnguardarregisto.TabIndex = 3;
            btnguardarregisto.Text = "Registar";
            btnguardarregisto.UseVisualStyleBackColor = true;
            btnguardarregisto.Click += btnguardarregisto_Click;
            // 
            // btntodosregistos
            // 
            btntodosregistos.Location = new Point(672, 337);
            btntodosregistos.Name = "btntodosregistos";
            btntodosregistos.Size = new Size(119, 97);
            btntodosregistos.TabIndex = 4;
            btntodosregistos.Text = "Mostrar Registos";
            btntodosregistos.UseVisualStyleBackColor = true;
            btntodosregistos.Click += btntodosregistos_Click;
            // 
            // checkBoxpassword
            // 
            checkBoxpassword.AutoSize = true;
            checkBoxpassword.Location = new Point(510, 298);
            checkBoxpassword.Name = "checkBoxpassword";
            checkBoxpassword.Size = new Size(120, 19);
            checkBoxpassword.TabIndex = 5;
            checkBoxpassword.Text = "Mostrar Password";
            checkBoxpassword.UseVisualStyleBackColor = true;
            checkBoxpassword.CheckedChanged += checkBoxpassword_CheckedChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(323, 92);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(198, 23);
            txtNome.TabIndex = 6;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(323, 148);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(198, 23);
            txtGmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(323, 214);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(198, 23);
            txtPassword.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtGmail);
            Controls.Add(txtNome);
            Controls.Add(checkBoxpassword);
            Controls.Add(btntodosregistos);
            Controls.Add(btnguardarregisto);
            Controls.Add(Password);
            Controls.Add(Gmail);
            Controls.Add(Nome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nome;
        private Label Gmail;
        private Label Password;
        private Button btnguardarregisto;
        private Button btntodosregistos;
        private CheckBox checkBoxpassword;
        private TextBox txtNome;
        private TextBox txtGmail;
        private TextBox txtPassword;
    }
}