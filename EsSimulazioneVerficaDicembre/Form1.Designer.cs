namespace EsSimulazioneVerficaDicembre
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnpushmotrice = new System.Windows.Forms.Button();
            this.btnpopmotrice = new System.Windows.Forms.Button();
            this.listBoxMotrice = new System.Windows.Forms.ListBox();
            this.listBoxRimorchio = new System.Windows.Forms.ListBox();
            this.btnpoprimorchio = new System.Windows.Forms.Button();
            this.btnpushrimorchio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "codice";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(287, 37);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 22);
            this.txtcod.TabIndex = 1;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(287, 94);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(100, 22);
            this.txtdesc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "descrizione";
            // 
            // btnpushmotrice
            // 
            this.btnpushmotrice.Location = new System.Drawing.Point(86, 152);
            this.btnpushmotrice.Name = "btnpushmotrice";
            this.btnpushmotrice.Size = new System.Drawing.Size(101, 43);
            this.btnpushmotrice.TabIndex = 4;
            this.btnpushmotrice.Text = "Push Motrice";
            this.btnpushmotrice.UseVisualStyleBackColor = true;
            this.btnpushmotrice.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnpopmotrice
            // 
            this.btnpopmotrice.Location = new System.Drawing.Point(86, 466);
            this.btnpopmotrice.Name = "btnpopmotrice";
            this.btnpopmotrice.Size = new System.Drawing.Size(101, 43);
            this.btnpopmotrice.TabIndex = 5;
            this.btnpopmotrice.Text = "Pop Motrice";
            this.btnpopmotrice.UseVisualStyleBackColor = true;
            this.btnpopmotrice.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxMotrice
            // 
            this.listBoxMotrice.FormattingEnabled = true;
            this.listBoxMotrice.ItemHeight = 16;
            this.listBoxMotrice.Location = new System.Drawing.Point(35, 219);
            this.listBoxMotrice.Name = "listBoxMotrice";
            this.listBoxMotrice.Size = new System.Drawing.Size(201, 228);
            this.listBoxMotrice.TabIndex = 7;
            // 
            // listBoxRimorchio
            // 
            this.listBoxRimorchio.FormattingEnabled = true;
            this.listBoxRimorchio.ItemHeight = 16;
            this.listBoxRimorchio.Location = new System.Drawing.Point(324, 219);
            this.listBoxRimorchio.Name = "listBoxRimorchio";
            this.listBoxRimorchio.Size = new System.Drawing.Size(201, 228);
            this.listBoxRimorchio.TabIndex = 10;
            // 
            // btnpoprimorchio
            // 
            this.btnpoprimorchio.Location = new System.Drawing.Point(375, 466);
            this.btnpoprimorchio.Name = "btnpoprimorchio";
            this.btnpoprimorchio.Size = new System.Drawing.Size(101, 43);
            this.btnpoprimorchio.TabIndex = 9;
            this.btnpoprimorchio.Text = "Pop Rimorchio";
            this.btnpoprimorchio.UseVisualStyleBackColor = true;
            this.btnpoprimorchio.Click += new System.EventHandler(this.btnpoprimorchio_Click);
            // 
            // btnpushrimorchio
            // 
            this.btnpushrimorchio.Location = new System.Drawing.Point(375, 152);
            this.btnpushrimorchio.Name = "btnpushrimorchio";
            this.btnpushrimorchio.Size = new System.Drawing.Size(101, 43);
            this.btnpushrimorchio.TabIndex = 8;
            this.btnpushrimorchio.Text = "Push Rimorchio";
            this.btnpushrimorchio.UseVisualStyleBackColor = true;
            this.btnpushrimorchio.Click += new System.EventHandler(this.btnpushrimorchio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.listBoxRimorchio);
            this.Controls.Add(this.btnpoprimorchio);
            this.Controls.Add(this.btnpushrimorchio);
            this.Controls.Add(this.listBoxMotrice);
            this.Controls.Add(this.btnpopmotrice);
            this.Controls.Add(this.btnpushmotrice);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnpushmotrice;
        private System.Windows.Forms.Button btnpopmotrice;
        private System.Windows.Forms.ListBox listBoxMotrice;
        private System.Windows.Forms.ListBox listBoxRimorchio;
        private System.Windows.Forms.Button btnpoprimorchio;
        private System.Windows.Forms.Button btnpushrimorchio;
    }
}

