namespace AS2223_4G_INF_UbaldiEdoardo_LetturaCSV
{
    public partial class frm_Main : Form
    {
        List<string> nomi = new List<string>();
        List<string> cognomi = new List<string>();
        List<string> citta = new List<string>();
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Cerca_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            StreamReader reader = new StreamReader(openFileDialog.FileName);
            txt_File.Text = openFileDialog.FileName;
                while (!reader.EndOfStream)
                {
                    var riga = reader.ReadToEnd();
                    var contenuto = riga.Split(';','\n');
                    
                nomi.Add(contenuto[0]);
                cognomi.Add(contenuto[1]);
                citta.Add(contenuto[2]);

                nomi.Add(contenuto[3]);
                cognomi.Add(contenuto[4]);
                citta.Add(contenuto[5]);

                nomi.Add(contenuto[6]);
                cognomi.Add(contenuto[7]);
                citta.Add(contenuto[8]);

                nomi.Add(contenuto[9]);
                cognomi.Add(contenuto[10]);
                citta.Add(contenuto[11]);

                nomi.Add(contenuto[12]);
                cognomi.Add(contenuto[13]);
                citta.Add(contenuto[14]);
            }
        }

        private void btn_Visualizza_Click(object sender, EventArgs e)
        {
            lst_NomiCognomiCitta.Items.Clear();
            for(int i = 0; i < nomi.Count; i++)
            {
                lst_NomiCognomiCitta.Items.Add(nomi.ElementAt(i) + ", " + cognomi.ElementAt(i) + ", " + citta.ElementAt(i));
            }
        }
    }
}
