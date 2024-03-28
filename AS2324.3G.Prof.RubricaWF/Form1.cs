namespace AS2324._3G.Prof.RubricaWF
{
    public partial class Form1 : Form
    {
        const int nMaxContatti = 100;

        int nRecordInseriti = 0;

        // definizione array paralleli
        string[] cognome = new string[nMaxContatti];
        string[] nome = new string[nMaxContatti];
        string[] email = new string[nMaxContatti];
        string[] nickname = new string[nMaxContatti];
        int[] simpatia = new int[nMaxContatti];
        int[] annoNascita = new int[nMaxContatti];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            if (cmbRicerca.Text == "")
            {
                MessageBox.Show("E' necessario definire il campo di ricerca.");
            }
            if (txtRicerca.Text == "")
            {
                MessageBox.Show("E' necessario definire il campo di ricerca.");
            }
            else
            {
                if (cmbRicerca.Text == "Nome")
                {
                    if (cmbOpzioni.Text == "Inizia per")
                    {
                        for (int i = 0; i < nRecordInseriti; i++)
                        {
                            if (nome[i].ToUpper().StartsWith(txtRicerca.Text.ToUpper()) == true)
                            {
                                lstElenco.Items.Add(nome[i]);
                            }
                        }
                    }
                    if (cmbOpzioni.Text == "Finisce per")
                    {
                        for (int i = 0; i < nRecordInseriti; i++)
                        {
                            if (nome[i].ToUpper().EndsWith(txtRicerca.Text.ToUpper()) == true)
                            {
                                lstElenco.Items.Add(nome[i]);
                            }
                        }
                    }
                    if (cmbOpzioni.Text == "Contiene")
                    {
                        for (int i = 0; i < nRecordInseriti; i++)
                        {
                            if (nome[i].ToUpper().Contains(txtRicerca.Text.ToUpper()) == true)
                            {
                                lstElenco.Items.Add(nome[i]);
                            }
                        }
                    }

                }
                if (cmbRicerca.Text == "Cognome")
                {
                    if (cmbOpzioni.Text == "Inizia per")
                    {
                        for (int i = 0; i < nRecordInseriti; i++)
                        {
                            if (cognome[i].ToUpper().StartsWith(txtRicerca.Text.ToUpper()) == true)
                            {
                                lstElenco.Items.Add(cognome[i]);
                            }
                        }
                    }
                    if (cmbOpzioni.Text == "Finisce per")
                    {
                        for (int i = 0; i < nRecordInseriti; i++)
                        {
                            if (cognome[i].ToUpper().EndsWith(txtRicerca.Text.ToUpper()) == true)
                            {
                                lstElenco.Items.Add(cognome[i]);
                            }
                        }
                    }
                    if (cmbOpzioni.Text == "Contiene")
                    {
                        for (int i = 0; i < nRecordInseriti; i++)
                        {
                            if (cognome[i].ToUpper().Contains(txtRicerca.Text.ToUpper()) == true)
                            {
                                lstElenco.Items.Add(cognome[i]);
                            }
                        }
                    }

                }
                if (cmbRicerca.Text == "NickName")
                {
                    if (cmbOpzioni.Text == "Inizia per")
                    {
                        for (int i = 0; i < nRecordInseriti; i++)
                        {
                            if (nickname[i].ToUpper().StartsWith(txtRicerca.Text.ToUpper()) == true)
                            {
                                lstElenco.Items.Add(nickname[i]);
                            }
                        }
                    }
                    if (cmbOpzioni.Text == "Finisce per")
                    {
                        for (int i = 0; i < nRecordInseriti; i++)
                        {
                            if (nickname[i].ToUpper().EndsWith(txtRicerca.Text.ToUpper()) == true)
                            {
                                lstElenco.Items.Add(nickname[i]);
                            }
                        }
                    }
                    if (cmbOpzioni.Text == "Contiene")
                    {
                        for (int i = 0; i < nRecordInseriti; i++)
                        {
                            if (nickname[i].ToUpper().Contains(txtRicerca.Text.ToUpper()) == true)
                            {
                                lstElenco.Items.Add(nickname[i]);
                            }
                        }
                    }
                }
            }
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            cognome[nRecordInseriti] = txtCognome.Text;
            nome[nRecordInseriti] = txtNome.Text;
            email[nRecordInseriti] = txtEmail.Text;
            simpatia[nRecordInseriti] = cmbSimpatia.SelectedIndex;
            annoNascita[nRecordInseriti] = Convert.ToInt32(txtAnnoNascita.Text);
            nickname[nRecordInseriti] = txtNickName.Text;
            nRecordInseriti++;
            lblNRecord.Text = "N. record inseriti: " + nRecordInseriti;
        }

        private void btnElenca_Click(object sender, EventArgs e)
        {
            lstElenco.Items.Clear();

            for (int i = 0; i < nRecordInseriti; i++)
            {
                lstElenco.Items.Add($"{nome[i]} {cognome[i]} ({email[i]}) - Simpatia: {simpatia[i]} - Anno di nascita: {annoNascita[i]} - Nickname: {nickname[i]}");
            }
        }

    }
}
