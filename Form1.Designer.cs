namespace AS2223_4G_INF_UbaldiEdoardo_LetturaCSV
{
    partial class frm_Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_File = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_Cerca = new System.Windows.Forms.Button();
            this.lst_NomiCognomiCitta = new System.Windows.Forms.ListBox();
            this.txt_Cognome = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Visualizza = new System.Windows.Forms.Button();
            this.cmb_Filtro = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // txt_File
            // 
            this.txt_File.Location = new System.Drawing.Point(119, 60);
            this.txt_File.Name = "txt_File";
            this.txt_File.Size = new System.Drawing.Size(552, 27);
            this.txt_File.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btn_Cerca
            // 
            this.btn_Cerca.Location = new System.Drawing.Point(677, 60);
            this.btn_Cerca.Name = "btn_Cerca";
            this.btn_Cerca.Size = new System.Drawing.Size(33, 29);
            this.btn_Cerca.TabIndex = 2;
            this.btn_Cerca.Text = "...";
            this.btn_Cerca.UseVisualStyleBackColor = true;
            this.btn_Cerca.Click += new System.EventHandler(this.btn_Cerca_Click);
            // 
            // lst_NomiCognomiCitta
            // 
            this.lst_NomiCognomiCitta.FormattingEnabled = true;
            this.lst_NomiCognomiCitta.ItemHeight = 20;
            this.lst_NomiCognomiCitta.Location = new System.Drawing.Point(78, 222);
            this.lst_NomiCognomiCitta.Name = "lst_NomiCognomiCitta";
            this.lst_NomiCognomiCitta.Size = new System.Drawing.Size(750, 104);
            this.lst_NomiCognomiCitta.TabIndex = 3;
            // 
            // txt_Cognome
            // 
            this.txt_Cognome.Location = new System.Drawing.Point(240, 116);
            this.txt_Cognome.Name = "txt_Cognome";
            this.txt_Cognome.Size = new System.Drawing.Size(431, 27);
            this.txt_Cognome.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Contiene",
            "Inizia con",
            "Finisce con"});
            this.comboBox1.Location = new System.Drawing.Point(677, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // btn_Visualizza
            // 
            this.btn_Visualizza.Location = new System.Drawing.Point(386, 171);
            this.btn_Visualizza.Name = "btn_Visualizza";
            this.btn_Visualizza.Size = new System.Drawing.Size(94, 29);
            this.btn_Visualizza.TabIndex = 7;
            this.btn_Visualizza.Text = "Visualizza";
            this.btn_Visualizza.UseVisualStyleBackColor = true;
            // 
            // cmb_Filtro
            // 
            this.cmb_Filtro.FormattingEnabled = true;
            this.cmb_Filtro.Items.AddRange(new object[] {
            "Nome",
            "Cognome",
            "Città"});
            this.cmb_Filtro.Location = new System.Drawing.Point(78, 116);
            this.cmb_Filtro.Name = "cmb_Filtro";
            this.cmb_Filtro.Size = new System.Drawing.Size(151, 28);
            this.cmb_Filtro.TabIndex = 8;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 366);
            this.Controls.Add(this.cmb_Filtro);
            this.Controls.Add(this.btn_Visualizza);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_Cognome);
            this.Controls.Add(this.lst_NomiCognomiCitta);
            this.Controls.Add(this.btn_Cerca);
            this.Controls.Add(this.txt_File);
            this.Controls.Add(this.label1);
            this.Name = "frm_Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_File;
        private OpenFileDialog openFileDialog;
        private Button btn_Cerca;
        private ListBox lst_NomiCognomiCitta;
        private TextBox txt_Cognome;
        private ComboBox comboBox1;
        private Button btn_Visualizza;
        private ComboBox cmb_Filtro;
    }
}