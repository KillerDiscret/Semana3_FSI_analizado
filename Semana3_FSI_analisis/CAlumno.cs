using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_FSI_analisis
{
    //se pone public a la clase que va a heredar
   public class CAlumno:CPersona
    {

        private int nrocursos;
        public int Nrocursos { get; set; }
        private string carreraprofesional;
        public string CarreraProfesional { get; set; }
        //inicializamos la clase(CONSTRUCTOR)
        //base es para referirse a la clase que se hereda y es como una variable para 
        //acceder a las otras funciones que tengan virtual como descripcion
        public CAlumno(int pnrocursos, string carprof,int codigo ,string nombre):base(codigo, nombre)
        {
            //se iguala a la funcion porque almacenará su get
            Nrocursos = pnrocursos;
            CarreraProfesional = carprof;
        }
        public override string Informacion()
        {
            //al presionar tap cuando escribes override sale lo de abajo
            //return base.Informacion();
            //sirve para retornar lo escrito en otra funcion que pertenece a otra clase
            string info = base.Informacion();
            info = info + "\t" + CarreraProfesional + "\t" + Nrocursos;
            return info;
        }


    }
}
