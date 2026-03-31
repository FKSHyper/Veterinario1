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
            btnDef = new Button();
            panelBtn = new Panel();
            btnHistoric = new Button();
            btnCons = new Button();
            btnClients = new Button();
            plAnimal = new Panel();
            Animal = new Label();
            button3 = new Button();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            plCliente = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            txtSeta = new Label();
            txtDef = new Label();
            panelLogin = new Panel();
            button7 = new Button();
            txtPass = new TextBox();
            label2 = new Label();
            txtLogin = new TextBox();
            label1 = new Label();
            textBox12 = new TextBox();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelBtn.SuspendLayout();
            plAnimal.SuspendLayout();
            plCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelLogin.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(btnDef);
            splitContainer1.Panel1.Controls.Add(panelBtn);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(plCliente);
            splitContainer1.Panel2.Controls.Add(txtSeta);
            splitContainer1.Panel2.Controls.Add(txtDef);
            splitContainer1.Panel2.Controls.Add(panelLogin);
            splitContainer1.Size = new Size(1146, 643);
            splitContainer1.SplitterDistance = 136;
            splitContainer1.TabIndex = 0;
            // 
            // btnDef
            // 
            btnDef.Location = new Point(16, 566);
            btnDef.Name = "btnDef";
            btnDef.Size = new Size(100, 39);
            btnDef.TabIndex = 7;
            btnDef.Text = "Definições";
            btnDef.UseVisualStyleBackColor = true;
            btnDef.Click += btnDef_Click;
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
            btnClients.Click += btnClients_Click;
            // 
            // plAnimal
            // 
            plAnimal.Controls.Add(Animal);
            plAnimal.Controls.Add(button3);
            plAnimal.Controls.Add(textBox11);
            plAnimal.Controls.Add(textBox10);
            plAnimal.Controls.Add(textBox9);
            plAnimal.Controls.Add(textBox8);
            plAnimal.Controls.Add(textBox7);
            plAnimal.Controls.Add(textBox6);
            plAnimal.Controls.Add(label13);
            plAnimal.Controls.Add(label12);
            plAnimal.Controls.Add(label11);
            plAnimal.Controls.Add(label10);
            plAnimal.Controls.Add(label9);
            plAnimal.Controls.Add(label8);
            plAnimal.Location = new Point(0, 3);
            plAnimal.Name = "plAnimal";
            plAnimal.Size = new Size(1000, 463);
            plAnimal.TabIndex = 1;
            plAnimal.Paint += plAnimal_Paint;
            // 
            // Animal
            // 
            Animal.AutoSize = true;
            Animal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Animal.Location = new Point(360, 41);
            Animal.Name = "Animal";
            Animal.Size = new Size(88, 32);
            Animal.TabIndex = 16;
            Animal.Text = "Animal";
            // 
            // button3
            // 
            button3.Location = new Point(792, 222);
            button3.Name = "button3";
            button3.Size = new Size(80, 30);
            button3.TabIndex = 15;
            button3.Text = "Registo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(136, 368);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(563, 23);
            textBox11.TabIndex = 14;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(136, 313);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(563, 23);
            textBox10.TabIndex = 13;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(136, 263);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(563, 23);
            textBox9.TabIndex = 12;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(136, 213);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(563, 23);
            textBox8.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(136, 166);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(563, 23);
            textBox7.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(136, 114);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(563, 23);
            textBox6.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(98, 371);
            label13.Name = "label13";
            label13.Size = new Size(32, 15);
            label13.TabIndex = 8;
            label13.Text = "Chip";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(98, 321);
            label12.Name = "label12";
            label12.Size = new Size(32, 15);
            label12.TabIndex = 7;
            label12.Text = "Peso";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(94, 271);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 6;
            label11.Text = "Idade";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(91, 221);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 5;
            label10.Text = "Ração";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(84, 174);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 4;
            label9.Text = "Espécie";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(84, 122);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 3;
            label8.Text = "Nome";
            // 
            // plCliente
            // 
            plCliente.Controls.Add(label14);
            plCliente.Controls.Add(textBox12);
            plCliente.Controls.Add(plAnimal);
            plCliente.Controls.Add(dataGridView1);
            plCliente.Controls.Add(textBox5);
            plCliente.Controls.Add(textBox4);
            plCliente.Controls.Add(textBox3);
            plCliente.Controls.Add(textBox2);
            plCliente.Controls.Add(textBox1);
            plCliente.Controls.Add(label7);
            plCliente.Controls.Add(label6);
            plCliente.Controls.Add(label5);
            plCliente.Controls.Add(label4);
            plCliente.Controls.Add(label3);
            plCliente.Controls.Add(button2);
            plCliente.Controls.Add(button1);
            plCliente.Location = new Point(3, 3);
            plCliente.Name = "plCliente";
            plCliente.Size = new Size(1003, 637);
            plCliente.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(33, 289);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(923, 237);
            dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nome";
            Column1.Name = "Column1";
            Column1.Width = 110;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nif";
            Column2.Name = "Column2";
            Column2.Width = 110;
            // 
            // Column3
            // 
            Column3.HeaderText = "Telefone";
            Column3.Name = "Column3";
            Column3.Width = 110;
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.Name = "Column4";
            Column4.Width = 110;
            // 
            // Column5
            // 
            Column5.HeaderText = "Morada";
            Column5.Name = "Column5";
            Column5.Width = 110;
            // 
            // Column6
            // 
            Column6.HeaderText = "Animal";
            Column6.Name = "Column6";
            Column6.Width = 110;
            // 
            // Column7
            // 
            Column7.HeaderText = "Espécie";
            Column7.Name = "Column7";
            Column7.Width = 110;
            // 
            // Column8
            // 
            Column8.HeaderText = "Chip";
            Column8.Name = "Column8";
            Column8.Width = 110;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(136, 216);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(563, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(136, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(563, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 123);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(563, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(563, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(563, 23);
            textBox1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 224);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 6;
            label7.Text = "Morada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(92, 174);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 131);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 86);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 3;
            label4.Text = "Nif";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 43);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome";
            // 
            // button2
            // 
            button2.Location = new Point(695, 567);
            button2.Name = "button2";
            button2.Size = new Size(80, 30);
            button2.TabIndex = 1;
            button2.Text = "Pesquisar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(795, 123);
            button1.Name = "button1";
            button1.Size = new Size(80, 30);
            button1.TabIndex = 0;
            button1.Text = "Registo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSeta
            // 
            txtSeta.AutoSize = true;
            txtSeta.Font = new Font("Segoe UI", 40F);
            txtSeta.ForeColor = Color.Red;
            txtSeta.Location = new Point(3, 544);
            txtSeta.Name = "txtSeta";
            txtSeta.Size = new Size(844, 72);
            txtSeta.TabIndex = 6;
            txtSeta.Text = "<<<<<<<<<<<<<<<<<<<<<<";
            txtSeta.Visible = false;
            // 
            // txtDef
            // 
            txtDef.AutoSize = true;
            txtDef.Font = new Font("Segoe UI", 40F);
            txtDef.ForeColor = Color.Red;
            txtDef.Location = new Point(36, 472);
            txtDef.Name = "txtDef";
            txtDef.Size = new Size(932, 72);
            txtDef.TabIndex = 5;
            txtDef.Text = "Professor mandou, EM CONSTRUÇÃO";
            txtDef.Visible = false;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(button7);
            panelLogin.Controls.Add(txtPass);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(txtLogin);
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
            // txtPass
            // 
            txtPass.Location = new Point(103, 72);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(303, 23);
            txtPass.TabIndex = 3;
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
            // txtLogin
            // 
            txtLogin.Location = new Point(103, 9);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(303, 23);
            txtLogin.TabIndex = 1;
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
            // textBox12
            // 
            textBox12.Location = new Point(329, 572);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(360, 23);
            textBox12.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(292, 572);
            label14.Name = "label14";
            label14.Size = new Size(31, 21);
            label14.TabIndex = 14;
            label14.Text = "Nif";
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
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelBtn.ResumeLayout(false);
            plAnimal.ResumeLayout(false);
            plAnimal.PerformLayout();
            plCliente.ResumeLayout(false);
            plCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtPass;
        private Label label2;
        private TextBox txtLogin;
        private Label label1;
        private Button btnClients;
        private Panel panelLogin;
        private Button button4;
        private Button button5;
        private Button btnHistoric;
        private Button btnCons;
        private Button button7;
        private Panel panelBtn;
        private Button btnDef;
        private Label txtDef;
        private Label txtSeta;
        private Panel plCliente;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button2;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Panel plAnimal;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button button3;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label Animal;
        private Label label14;
        private TextBox textBox12;
    }
}
