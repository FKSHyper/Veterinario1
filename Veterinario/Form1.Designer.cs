namespace Veterinario
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
            splitContainer1 = new SplitContainer();
            panelBtn = new Panel();
            btnHistoric = new Button();
            btnCons = new Button();
            btnClients = new Button();
            panelLogin = new Panel();
            button7 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            AdicionarPet = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelBtn.SuspendLayout();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ActiveCaption;
            splitContainer1.Panel1.Controls.Add(panelBtn);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(panelLogin);
            splitContainer1.Size = new Size(1146, 643);
            splitContainer1.SplitterDistance = 136;
            splitContainer1.TabIndex = 0;
            // 
            // panelBtn
            // 
            panelBtn.Controls.Add(btnHistoric);
            panelBtn.Controls.Add(btnCons);
            panelBtn.Controls.Add(btnClients);
            panelBtn.Location = new Point(14, 18);
            panelBtn.Name = "panelBtn";
            panelBtn.Size = new Size(107, 189);
            panelBtn.TabIndex = 6;
            // 
            // btnHistoric
            // 
            btnHistoric.Location = new Point(2, 139);
            btnHistoric.Name = "btnHistoric";
            btnHistoric.Size = new Size(100, 39);
            btnHistoric.TabIndex = 2;
            btnHistoric.Text = "Historico";
            btnHistoric.UseVisualStyleBackColor = true;
            // 
            // btnCons
            // 
            btnCons.Location = new Point(2, 70);
            btnCons.Name = "btnCons";
            btnCons.Size = new Size(100, 39);
            btnCons.TabIndex = 1;
            btnCons.Text = "Consultas";
            btnCons.UseVisualStyleBackColor = true;
            // 
            // btnClients
            // 
            btnClients.Location = new Point(2, 2);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(100, 39);
            btnClients.TabIndex = 0;
            btnClients.Text = "Clientes";
            btnClients.UseVisualStyleBackColor = true;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(button7);
            panelLogin.Controls.Add(textBox2);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(textBox1);
            panelLogin.Controls.Add(label1);
            panelLogin.Location = new Point(276, 198);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(416, 193);
            panelLogin.TabIndex = 4;
            // 
            // button7
            // 
            button7.Location = new Point(276, 121);
            button7.Name = "button7";
            button7.Size = new Size(107, 48);
            button7.TabIndex = 5;
            button7.Text = "Entrar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(6, 72);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cliente, AdicionarPet });
            dataGridView1.Location = new Point(16, 413);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(535, 209);
            dataGridView1.TabIndex = 5;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "NomeCliente";
            Cliente.Name = "Cliente";
            // 
            // AdicionarPet
            // 
            AdicionarPet.HeaderText = "Add Pet";
            AdicionarPet.Name = "AdicionarPet";
            // 
            // button1
            // 
            button1.Location = new Point(156, 437);
            button1.Name = "button1";
            button1.Size = new Size(55, 24);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(217, 437);
            button2.Name = "button2";
            button2.Size = new Size(55, 24);
            button2.TabIndex = 7;
            button2.Text = "Del";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 643);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelBtn.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button btnClients;
        private Panel panelLogin;
        private Button button4;
        private Button button5;
        private Button btnHistoric;
        private Button btnCons;
        private Button button7;
        private Panel panelBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn AdicionarPet;
        private Button button2;
        private Button button1;
    }
}
