using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_FSI_analisis
{

    //se pone public abstract para que se puede heredar por otra clase
    public abstract class CPersona
    {
        private int codigo;
        /*public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;

            }
        }
        */
        //es lo mismo que solo poner get; set;
        public int Codigo { get; set; }

        public string nombre;
        public string Nombre { get; set; }

        //constructor
        public CPersona(int pcodigo, string pnombre)
        {
            //SE AGREGA A LA FUNCION PARA ACCEDER A SU RESPECTIVO SET
        
            Codigo = pcodigo;
            Nombre = pnombre;
        }
        //se pone public virtual para que esa funcion tambien pueda ser heredada
        public virtual string Informacion()
        {
            return Codigo + "\t" + Nombre;
        }


    }
}
