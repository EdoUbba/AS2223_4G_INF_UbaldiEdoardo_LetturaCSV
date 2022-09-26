namespace AS2223_4G_INF_UbaldiEdoardo_LetturaCSV
{
    public partial class frm_Main : Form
    {
        List<string> nomi = new List<string>();         //liste nella quale verranno salvate le informazioni del file csv
        List<string> cognomi = new List<string>();
        List<string> citta = new List<string>();
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Cerca_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();       //Serve ad aprire la finestra di selezione del file
            DialogResult result = openFileDialog.ShowDialog();
            
            StreamReader reader = new StreamReader(openFileDialog.FileName);    //apre il file selezionato
            txt_File.Text = openFileDialog.FileName;

                while (!reader.EndOfStream)                 //fino a quando non smette di leggere il file
                {
                    var riga = reader.ReadToEnd();              //legge l'intero file
                    var contenuto = riga.Split(';','\n');       //separa in più parti le stringhe divise da ";" e "(a capo)"
                    
                for(int i = 0; i < 21; i = i+3)
                {
                    nomi.Add(contenuto[i]);
                }
                for(int i = 1; i < 21; i = i+3)
                {
                    cognomi.Add(contenuto[i]);
                }
                for(int i = 2; i < 21; i = i+3)
                {
                    citta.Add(contenuto[i]);
                }
            }
        }
        
        private void btn_Visualizza_Click(object sender, EventArgs e)
        {
            lst_NomiCognomiCitta.Items.Clear();     //Cancella le informazioni presenti nella listbox
            for(int i = 0; i < nomi.Count; i++)     //for che stampa per ogni riga della list "nomi"
            {
                lst_NomiCognomiCitta.Items.Add(nomi.ElementAt(i) + ", " + cognomi.ElementAt(i) + ", " + citta.ElementAt(i));
            }
        }
    }
}
