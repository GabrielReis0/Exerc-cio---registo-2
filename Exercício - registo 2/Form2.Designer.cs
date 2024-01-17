namespace Exercício___registo_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label1 = new Label();
            btnmostrarregistos = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(297, 110);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(211, 304);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(297, 79);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 1;
            label1.Text = "Utilizadores Registados:";
            // 
            // btnmostrarregistos
            // 
            btnmostrarregistos.Location = new Point(536, 317);
            btnmostrarregistos.Name = "btnmostrarregistos";
            btnmostrarregistos.Size = new Size(134, 97);
            btnmostrarregistos.TabIndex = 2;
            btnmostrarregistos.Text = "Mostrar Registos";
            btnmostrarregistos.UseVisualStyleBackColor = true;
            btnmostrarregistos.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(536, 65);
            button1.Name = "button1";
            button1.Size = new Size(134, 86);
            button1.TabIndex = 3;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnmostrarregistos);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button btnmostrarregistos;
        private Button button1;
    }
}