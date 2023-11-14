using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtg
{
    class CarteTipo
    {
        public string Tipo { get; set; }
        public List<string> CarteDiTipo { get; set; }
        public CarteTipo(string tipo)
        {
            CarteDiTipo = new List<string>();
            Tipo = tipo;
        }
        /// <summary>
        /// bho vediamo
        /// </summary>
        /// <returns></returns>
        public string ButtaInStringa()
        {
            string qualcosa = "";
            foreach (var item in CarteDiTipo)
            {
                qualcosa += item+"$";
            }
            string check = qualcosa.Substring(0, qualcosa.Length - 1);
            return check;
                
        }
    }
    
}
