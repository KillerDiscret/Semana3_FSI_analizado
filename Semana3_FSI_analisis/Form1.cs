using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana3_FSI_analisis
{
    public partial class Form1 : Form
    {
        CArreglo objarreglo = new CArreglo();
        CAlumno objalumno = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            //creamos una variable para almacenar el textBox de cursos
            int ncursos = Convert.ToInt32(txtnrocursos.Text);
            //en este caso no se usa Convert porque todos los datos ingresados en el textBox
            //se muestran como string al usar su funcion .Text
            string carrera = cbocarrera.Text;
            //se usa ToInt32 porque ese tamaño pertenece al int
            int cod = Convert.ToInt32(txtcodigo.Text);
            string nom = txtnombre.Text;
            //creamos recien el arreglo para poder inicializarlo con sus parametros
            objalumno = new CAlumno(ncursos, carrera, cod, nom);
            //una vez creado el obj de tipo CAlumno e inicializado
            //se pasa a almacenar en el arreglo de tipo CArreglo
            objarreglo.Insertar(objalumno);
            //agregamos la funcion Informacion en el listBox que es para mostrar letras 
            lboxlista.Items.Add(objalumno.Informacion());
            txtcodigo.Clear();
            txtnombre.Clear();
            txtnrocursos.Clear();
            //deja al comboBox en blanco
            cbocarrera.SelectedIndex = -1;
            txtnrocursos.Focus();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text != "")
            {
                //el convert.ToInt es para mandar el paramentro como int 
                //ya que es eso lo unico que acepta como entrada
                objalumno = objarreglo.Buscar_por_codigo(Convert.ToInt32(txtcodigo.Text));
                if (objalumno != null)
                {
                    MessageBox.Show(objalumno.Nombre);
                }
            }
        }

        private void btncontar_Click(object sender, EventArgs e)
        {
            //se compara con -1 para ver si no esta vacio
            if (cbocarrera.SelectedIndex != -1)
            {
                int cantidadxcarrera = objarreglo.Contar_por_carrera(cbocarrera.Text);
                MessageBox.Show(cantidadxcarrera.ToString());

            }
        }
    }
}
