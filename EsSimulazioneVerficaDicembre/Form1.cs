using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsSimulazioneVerficaDicembre
{
    public partial class Form1 : Form
    {
        Pila a;
        Pila ar;
        Pallet p;
        Pallet pr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //push pallet della motrice
            p = new Pallet(txtcod.Text, txtdesc.Text); //creo nuovo pallet motrice
            if (a.push(p) == true) //controllo se ho fatto push motrice
            {
                MessageBox.Show("AGGIUNTO");
            }
            else
            {
                MessageBox.Show("AO NUN CE PIU' SPAZIO");
            }
            update(listBoxMotrice, a); //richiamo funzione update
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = new Pila(); //crea pila motrice
            ar = new Pila(); //crea pila rimorchio
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pop pallet della motrice
            Pallet premove = a.pop(); //creo pallet da rimuovere
            if(premove != null) //controllo se pallet motrice da rimuovere è diverso da null
            {
                MessageBox.Show("RIMOSSO ULTIMO ELEMENTO");
            }
            update(listBoxMotrice, a); //richiamo funzione update
        }

        private void btnpushrimorchio_Click(object sender, EventArgs e)
        {
            //push pallet del rimorchio
            pr = new Pallet(txtcod.Text, txtdesc.Text); //creo nuovo pallet rimorchio
            if (ar.push(pr) == true) //controllo se ho fatto push rimorchio
            {
                MessageBox.Show("AGGIUNTO"); 
            }
            else
            {
                MessageBox.Show("AO NUN CE PIU' SPAZIO");
            }
            update(listBoxRimorchio, ar); //richiamo funzione update
        }

        private void btnpoprimorchio_Click(object sender, EventArgs e)
        {
            //pop pallet del rimorchio
            Pallet prremove = ar.pop(); //creo pallet da rimuovere
            if (prremove != null) //controllo se pallet rimorchio da rimuovere è diverso da null
            {
                MessageBox.Show("RIMOSSO ULTIMO ELEMENTO"); //messaggio che hai rimosso il pallet
            }
            update(listBoxRimorchio, ar); //richiamo funzione update
        }
        private void update(ListBox lst, Pila pila)
        {
            lst.Items.Clear();
            string[] stampa = pila.visit(); //array stampa ha tutti gli elementi di visit
            for (int i = 0; i < 100; i++) //scorro array
            {
                if (!string.IsNullOrEmpty(stampa[i])) //controllo se array è null o pieno
                {
                    lst.Items.Add(stampa[i]); //stampa nella listbox
                }
            }
        }
    }
    public class Pallet
    {
        protected string codice;
        protected string descrizione;
        public Pallet(string codice, string descrizione)
        {
            this.codice = codice;
            this.descrizione = descrizione;
        }
        public string getCodice()
        {
            return codice;
        }
        public string getDescrizione()
        {
            return descrizione;
        }
    }
    public class Pila
    {
        protected int top;
        protected Pallet[] arrpallet;
        public Pila()
        {
            top = -1;
            arrpallet = new Pallet[100];
        }
        public bool push(Pallet pallet)
        {
            bool ret = false;
            if(top < arrpallet.Length)
            {
                top++;//incremento top (indice)
                arrpallet[top] = pallet; //aggiungo pallet all'array in posizione top
                ret = true;
            }
            else
            {
                MessageBox.Show("PILA PIENA");
                ret = false;
            }
            return ret;
        }
        public Pallet pop()
        {
            Pallet rempallet = null;
            if (top > -1)
            {
                rempallet = arrpallet[top];
                arrpallet[top] = null;//tolgo dall'array l'ultimo elemento inserito
                top--;
            }
            return rempallet;
        }
        public string[] visit()
        {
            string[] stamp = new string[100];
            for(int i = 0; i < arrpallet.Length; i++)
            {
                if (arrpallet[i] != null)
                {
                    stamp[i] = arrpallet[i].getCodice() + " - " + arrpallet[i].getDescrizione();
                }
            }
            return stamp;
        }

    }
}
