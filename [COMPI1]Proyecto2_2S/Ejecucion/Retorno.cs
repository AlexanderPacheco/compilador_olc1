using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _COMPI1_Proyecto2_2S.Ejecucion
{
    class Retorno
    {
        public String Tipo;
        public String Valor;
        public String Linea;
        public String Columna;
        public Boolean RetornaVal;
        public Boolean Detener;
        public Boolean Retorna;

        public Retorno(String Tipo, String Valor, String Linea, String Columna)
        {
            this.Tipo = Tipo;
            this.Valor = Valor;
            this.Linea = Linea;
            this.Columna = Columna;
            this.RetornaVal = false;
            this.Detener = false;
            this.Retorna = false;
        }
    }
}
