namespace AS2324._3G.Prof.RubricaWF
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
            label1 = new Label();
            txtCognome = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtNickName = new TextBox();
            label5 = new Label();
            cmbSimpatia = new ComboBox();
            label6 = new Label();
            txtAnnoNascita = new TextBox();
            groupBox1 = new GroupBox();
            btnAggiungi = new Button();
            lblNRecord = new Label();
            groupBox2 = new GroupBox();
            btnRicerca = new Button();
            lstElenco = new ListBox();
            cmbOpzioni = new ComboBox();
            cmbRicerca = new ComboBox();
            btnElenca = new Button();
            label7 = new Label();
            txtRicerca = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 36);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Cognome";
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(120, 33);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(201, 27);
            txtCognome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 39);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(437, 36);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(201, 27);
            txtNome.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 69);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 66);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(201, 27);
            txtEmail.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 72);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 0;
            label4.Text = "NickName";
            // 
            // txtNickName
            // 
            txtNickName.Location = new Point(437, 69);
            txtNickName.Name = "txtNickName";
            txtNickName.Size = new Size(125, 27);
            txtNickName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 100);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 0;
            label5.Text = "Simpatia";
            // 
            // cmbSimpatia
            // 
            cmbSimpatia.FormattingEnabled = true;
            cmbSimpatia.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbSimpatia.Location = new Point(120, 99);
            cmbSimpatia.Name = "cmbSimpatia";
            cmbSimpatia.Size = new Size(67, 28);
            cmbSimpatia.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 105);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 0;
            label6.Text = "Anno nascita";
            // 
            // txtAnnoNascita
            // 
            txtAnnoNascita.Location = new Point(437, 102);
            txtAnnoNascita.Name = "txtAnnoNascita";
            txtAnnoNascita.Size = new Size(67, 27);
            txtAnnoNascita.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAggiungi);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(cmbSimpatia);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNickName);
            groupBox1.Controls.Add(txtCognome);
            groupBox1.Controls.Add(lblNRecord);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAnnoNascita);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(752, 233);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dati contatto :";
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(298, 147);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(133, 72);
            btnAggiungi.TabIndex = 4;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // lblNRecord
            // 
            lblNRecord.AutoSize = true;
            lblNRecord.Location = new Point(569, 199);
            lblNRecord.Name = "lblNRecord";
            lblNRecord.Size = new Size(125, 20);
            lblNRecord.TabIndex = 0;
            lblNRecord.Text = "N. record inseriti :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRicerca);
            groupBox2.Controls.Add(lstElenco);
            groupBox2.Controls.Add(cmbOpzioni);
            groupBox2.Controls.Add(cmbRicerca);
            groupBox2.Controls.Add(btnElenca);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtRicerca);
            groupBox2.Location = new Point(11, 264);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(753, 247);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ricerca :";
            // 
            // btnRicerca
            // 
            btnRicerca.Location = new Point(535, 30);
            btnRicerca.Name = "btnRicerca";
            btnRicerca.Size = new Size(94, 29);
            btnRicerca.TabIndex = 4;
            btnRicerca.Text = "Ricerca";
            btnRicerca.UseVisualStyleBackColor = true;
            btnRicerca.Click += btnRicerca_Click;
            // 
            // lstElenco
            // 
            lstElenco.FormattingEnabled = true;
            lstElenco.ItemHeight = 20;
            lstElenco.Location = new Point(8, 73);
            lstElenco.Name = "lstElenco";
            lstElenco.Size = new Size(730, 164);
            lstElenco.TabIndex = 3;
            // 
            // cmbOpzioni
            // 
            cmbOpzioni.FormattingEnabled = true;
            cmbOpzioni.Items.AddRange(new object[] { "Inizia per", "Finisce per", "Contiene" });
            cmbOpzioni.Location = new Point(404, 29);
            cmbOpzioni.Name = "cmbOpzioni";
            cmbOpzioni.Size = new Size(117, 28);
            cmbOpzioni.TabIndex = 2;
            // 
            // cmbRicerca
            // 
            cmbRicerca.FormattingEnabled = true;
            cmbRicerca.Items.AddRange(new object[] { "Nome", "Cognome", "NickName" });
            cmbRicerca.Location = new Point(97, 30);
            cmbRicerca.Name = "cmbRicerca";
            cmbRicerca.Size = new Size(117, 28);
            cmbRicerca.TabIndex = 2;
            // 
            // btnElenca
            // 
            btnElenca.Location = new Point(644, 30);
            btnElenca.Name = "btnElenca";
            btnElenca.Size = new Size(94, 29);
            btnElenca.TabIndex = 2;
            btnElenca.Text = "Elenca";
            btnElenca.UseVisualStyleBackColor = true;
            btnElenca.Click += btnElenca_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 34);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 0;
            label7.Text = "Ricerca per";
            // 
            // txtRicerca
            // 
            txtRicerca.Location = new Point(220, 29);
            txtRicerca.Name = "txtRicerca";
            txtRicerca.Size = new Size(178, 27);
            txtRicerca.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 536);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Prof;3G;21/03/24;Rubrica di nominativi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtCognome;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtNickName;
        private Label label5;
        private ComboBox cmbSimpatia;
        private Label label6;
        private TextBox txtAnnoNascita;
        private GroupBox groupBox1;
        private Button btnAggiungi;
        private GroupBox groupBox2;
        private ListBox lstElenco;
        private Button btnElenca;
        private Label label7;
        private TextBox txtRicerca;
        private Button btnRicerca;
        private ComboBox cmbRicerca;
        private ComboBox cmbOpzioni;
        private Label lblNRecord;
    }
}
