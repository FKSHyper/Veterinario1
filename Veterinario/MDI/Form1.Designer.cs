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
            btnLogout = new Button();
            btnDef = new Button();
            panelBtn = new Panel();
            btnHistoric = new Button();
            btnCons = new Button();
            btnClients = new Button();
            plCliente = new Panel();
            label14 = new Label();
            textBox12 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
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
            btnPesquisar = new Button();
            button1 = new Button();
            plAnimal = new Panel();
            textBox13 = new TextBox();
            label15 = new Label();
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
            txtSeta = new Label();
            txtDef = new Label();
            panelLogin = new Panel();
            button7 = new Button();
            txtPass = new TextBox();
            label2 = new Label();
            txtLogin = new TextBox();
            label1 = new Label();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelBtn.SuspendLayout();
            plCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            plAnimal.SuspendLayout();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ActiveCaption;
            splitContainer1.Panel1.Controls.Add(btnLogout);
            splitContainer1.Panel1.Controls.Add(btnDef);
            splitContainer1.Panel1.Controls.Add(panelBtn);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(plCliente);
            splitContainer1.Panel2.Controls.Add(plAnimal);
            splitContainer1.Panel2.Controls.Add(txtSeta);
            splitContainer1.Panel2.Controls.Add(txtDef);
            splitContainer1.Panel2.Controls.Add(panelLogin);
            splitContainer1.Size = new Size(1310, 857);
            splitContainer1.SplitterDistance = 155;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Location = new Point(17, 695);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(114, 52);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDef
            // 
            btnDef.Location = new Point(18, 755);
            btnDef.Margin = new Padding(3, 4, 3, 4);
            btnDef.Name = "btnDef";
            btnDef.Size = new Size(114, 52);
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
            panelBtn.Location = new Point(16, 24);
            panelBtn.Margin = new Padding(3, 4, 3, 4);
            panelBtn.Name = "panelBtn";
            panelBtn.Size = new Size(122, 252);
            panelBtn.TabIndex = 6;
            // 
            // btnHistoric
            // 
            btnHistoric.Location = new Point(2, 185);
            btnHistoric.Margin = new Padding(3, 4, 3, 4);
            btnHistoric.Name = "btnHistoric";
            btnHistoric.Size = new Size(114, 52);
            btnHistoric.TabIndex = 2;
            btnHistoric.Text = "Historico";
            btnHistoric.UseVisualStyleBackColor = true;
            btnHistoric.Click += btnHistoric_Click;
            // 
            // btnCons
            // 
            btnCons.Location = new Point(2, 93);
            btnCons.Margin = new Padding(3, 4, 3, 4);
            btnCons.Name = "btnCons";
            btnCons.Size = new Size(114, 52);
            btnCons.TabIndex = 1;
            btnCons.Text = "Consultas";
            btnCons.UseVisualStyleBackColor = true;
            btnCons.Click += btnCons_Click;
            // 
            // btnClients
            // 
            btnClients.Location = new Point(2, 3);
            btnClients.Margin = new Padding(3, 4, 3, 4);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(114, 52);
            btnClients.TabIndex = 0;
            btnClients.Text = "Clientes";
            btnClients.UseVisualStyleBackColor = true;
            btnClients.Click += btnClients_Click;
            // 
            // plCliente
            // 
            plCliente.Controls.Add(label14);
            plCliente.Controls.Add(textBox12);
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
            plCliente.Controls.Add(btnPesquisar);
            plCliente.Controls.Add(button1);
            plCliente.Location = new Point(3, 4);
            plCliente.Margin = new Padding(3, 4, 3, 4);
            plCliente.Name = "plCliente";
            plCliente.Size = new Size(1146, 849);
            plCliente.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(47, 764);
            label14.Name = "label14";
            label14.Size = new Size(38, 28);
            label14.TabIndex = 14;
            label14.Text = "Nif";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(89, 764);
            textBox12.Margin = new Padding(3, 4, 3, 4);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(411, 27);
            textBox12.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7, Column8 });
            dataGridView1.Location = new Point(33, 289);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(923, 237);
            dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Nome";
            Column1.HeaderText = "Nome";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Nif";
            Column2.HeaderText = "Nif";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Telefone";
            Column3.HeaderText = "Telefone";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Email";
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Morada";
            Column5.HeaderText = "Morada";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Especie";
            Column7.HeaderText = "Espécie";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.DataPropertyName = "Chip";
            Column8.HeaderText = "Chip";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(136, 216);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(563, 27);
            textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(136, 167);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(563, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 123);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(563, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 78);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(563, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 35);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(563, 27);
            textBox1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 224);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 6;
            label7.Text = "Morada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(92, 174);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 131);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 4;
            label5.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 86);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 3;
            label4.Text = "Nif";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 43);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Nome";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(695, 567);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(80, 30);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(795, 123);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(80, 30);
            button1.TabIndex = 0;
            button1.Text = "Registo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // plAnimal
            // 
            plAnimal.Controls.Add(textBox13);
            plAnimal.Controls.Add(label15);
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
            plAnimal.Location = new Point(0, 0);
            plAnimal.Margin = new Padding(3, 4, 3, 4);
            plAnimal.Name = "plAnimal";
            plAnimal.Size = new Size(1143, 617);
            plAnimal.TabIndex = 1;
            plAnimal.Paint += plAnimal_Paint;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(155, 547);
            textBox13.Margin = new Padding(3, 4, 3, 4);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(643, 27);
            textBox13.TabIndex = 18;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(103, 554);
            label15.Name = "label15";
            label15.Size = new Size(46, 20);
            label15.TabIndex = 17;
            label15.Text = "Dono";
            // 
            // Animal
            // 
            Animal.AutoSize = true;
            Animal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Animal.Location = new Point(411, 55);
            Animal.Name = "Animal";
            Animal.Size = new Size(109, 41);
            Animal.TabIndex = 16;
            Animal.Text = "Animal";
            // 
            // button3
            // 
            button3.Location = new Point(905, 296);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(91, 40);
            button3.TabIndex = 15;
            button3.Text = "Registo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(155, 482);
            textBox11.Margin = new Padding(3, 4, 3, 4);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(643, 27);
            textBox11.TabIndex = 14;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(155, 417);
            textBox10.Margin = new Padding(3, 4, 3, 4);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(643, 27);
            textBox10.TabIndex = 13;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(155, 351);
            textBox9.Margin = new Padding(3, 4, 3, 4);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(643, 27);
            textBox9.TabIndex = 12;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(155, 284);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(643, 27);
            textBox8.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(155, 221);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(643, 27);
            textBox7.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(155, 152);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(643, 27);
            textBox6.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(110, 489);
            label13.Name = "label13";
            label13.Size = new Size(39, 20);
            label13.TabIndex = 8;
            label13.Text = "Chip";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(112, 428);
            label12.Name = "label12";
            label12.Size = new Size(39, 20);
            label12.TabIndex = 7;
            label12.Text = "Peso";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(107, 361);
            label11.Name = "label11";
            label11.Size = new Size(47, 20);
            label11.TabIndex = 6;
            label11.Text = "Idade";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(104, 295);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 5;
            label10.Text = "Ração";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(96, 232);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 4;
            label9.Text = "Espécie";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(96, 163);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 3;
            label8.Text = "Nome";
            // 
            // txtSeta
            // 
            txtSeta.AutoSize = true;
            txtSeta.Font = new Font("Segoe UI", 40F);
            txtSeta.ForeColor = Color.Red;
            txtSeta.Location = new Point(3, 725);
            txtSeta.Name = "txtSeta";
            txtSeta.Size = new Size(1050, 89);
            txtSeta.TabIndex = 6;
            txtSeta.Text = "<<<<<<<<<<<<<<<<<<<<<<";
            txtSeta.Visible = false;
            // 
            // txtDef
            // 
            txtDef.AutoSize = true;
            txtDef.Font = new Font("Segoe UI", 40F);
            txtDef.ForeColor = Color.Red;
            txtDef.Location = new Point(41, 629);
            txtDef.Name = "txtDef";
            txtDef.Size = new Size(1152, 89);
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
            panelLogin.Location = new Point(272, 209);
            panelLogin.Margin = new Padding(3, 4, 3, 4);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(566, 338);
            panelLogin.TabIndex = 4;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            button7.Location = new Point(221, 179);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(122, 64);
            button7.TabIndex = 2;
            button7.Text = "Entrar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            txtPass.Location = new Point(118, 96);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(346, 41);
            txtPass.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label2.Location = new Point(7, 96);
            label2.Name = "label2";
            label2.Size = new Size(106, 36);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            txtLogin.Location = new Point(118, 12);
            txtLogin.Margin = new Padding(3, 4, 3, 4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(346, 41);
            txtLogin.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label1.Location = new Point(7, 12);
            label1.Name = "label1";
            label1.Size = new Size(95, 36);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // Column6
            // 
            Column6.HeaderText = "Animal";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 110;
            // 
            // Form1
            // 
            AcceptButton = button7;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 857);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelBtn.ResumeLayout(false);
            plCliente.ResumeLayout(false);
            plCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            plAnimal.ResumeLayout(false);
            plAnimal.PerformLayout();
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
        private Button btnPesquisar;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
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
        private Button btnLogout;
        private TextBox textBox13;
        private Label label15;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}
