using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_FSI_analisis
{
    public class CArreglo
    {
        private Array arr_Alumno = Array.CreateInstance(typeof(CAlumno), 100);
        private int indice = 0;
        public void Insertar(CAlumno obj)
        {
            arr_Alumno.SetValue(obj, indice);
            indice++;
        }
        public int Contar_por_carrera(string carrera)
        {
            int contador = 0;
            //elemento es la variable que almacena los datos que recolecta el foreach
            foreach (CAlumno elemento in arr_Alumno)
                if (elemento != null)
                    //elemento es un obj de tipo CAlumno y se puede manipular como un obj normal
                    if (elemento.CarreraProfesional == carrera)
                        contador++;
            return contador;
        }
        //esta funcion devuelve un obj de tipo CAlumno
        public CAlumno Buscar_por_codigo(int codigo)
        {
            //el delegate sirve para usar una funcion dentro del parámetro de método de comparacion
            CAlumno resultado = Array.Find((CAlumno[])arr_Alumno, delegate (CAlumno value)
            {
                if (value != null)
                    //retornara el value.Codigo si es igual al parametro codigo
                    return value.Codigo == codigo;
                else
                    return false;
            });
            return resultado;
            }
    }
}
