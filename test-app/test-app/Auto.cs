using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_app
{
    public class Auto
    {
        #region tipi
        
        //tipi personalizzati
        public enum motori
        {
            benzina, // valorizza a 0
            diesel, // valorizzato a 1
            elettrico // valorizzato a 2
        }

        #endregion

        #region proprietà

        //proprietà

        private int livellocarburante;

        /// <summary>
        /// caratteristiche del veicolo
        /// </summary>
        public string marca;
        public string modello;
        public string colore;
        public motori tipoMotore;
        private bool accesa;

        #endregion

        //costruttore per inizializzare le variabili
        public Auto()
        {
            this.marca = "fiat";
            this.modello = "punto";
            this.colore = "bianco";
            this.tipoMotore = motori.diesel;
        }

        //preparo la stringa che contiene le proprietà dell'auto
        public string Generadescrizione()
        {

            string result;

            result = "marca: " + this.marca + "\n";
            result += "modello: " + this.modello + "\n";
            result += "tipo di motore: " + this.tipoMotore + "\n";
            result += "colore: " + this.colore;

            return result;
        }

        public void stampastato()
        {
            Console.WriteLine(this.generastato());
        }
        /// <summary>
        /// genera lo stato (carburante, accensione, ...) 
        /// </summary>
        /// <returns></returns>
        public string generastato()
        {
            string result;

            result = $"carburante: {this.livellocarburante} \n";
            if (this.accesa)
            {
                //se il veicolo è acceso, scrivo "accesa"
                result += "accesa \n";
            }
            else
            {
                //altrimenti scrivo "spenta"
                result += "spenta \n";
            }

            return result;
        }

        //output della classe auto
        public void stampadescizione()
        {
            //stampo le caratteristiche dell'auto
            Console.WriteLine(Generadescrizione());
        }

        /// <summary>
        /// costruttore con i paramentri.
        /// </summary>
        /// <param name="marca">marca del veicolo</param>
        /// <param name="modello">modello del veicolo</param>
        /// <param name="colore">colore del veicolo</param>
        /// <param name="tipoMotore">tipo di motore del veicolo</param>

        public Auto(string marca, string modello, string colore, motori tipoMotore)
        {
            this.marca = marca;
            this.modello = modello;
            this.colore = colore;
            this.tipoMotore = tipoMotore;

        }

        /// <summary>
        /// tenta di avviare il veicolo <para>
        /// Se non c'e carburante l'accensione fallisce</para>
        /// </summary>
        public void accendi()
        {
            //verifico il livello del carburante
            if (this.livellocarburante > 0)
            {
                //Se è maggiore di 0 accendo il veicolo
                this.accesa = true;
            }
            else
            {
                //Se è minore o uguale di zero spengo il veicolo
                this.accesa = false;
            }


        }

        /// <summary>
        /// spegne il veicolo
        /// </summary>
        public void spegni()
        {
            //spegne il veicolo
            this.accesa = false;
        }

    }
}
