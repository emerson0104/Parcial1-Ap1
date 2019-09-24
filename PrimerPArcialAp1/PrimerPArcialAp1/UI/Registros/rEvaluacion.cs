using PrimerPArcialAp1.BLL;
using PrimerPArcialAp1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerPArcialAp1.UI.Registros
{
    public partial class rEvaluacion : Form
    {
        public rEvaluacion()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        public void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            EstudianteTextBox.Text = string.Empty;
            FechaDateTimePicker1.Value = DateTime.Now;
            ValorTextBox.Text = "";
            LogradoTextBox.Text = "";
            PerdidoTextBox.Text = "";
        }
        public Evaluacion Llenaclase()
        {
            Evaluacion evaluacion = new Evaluacion();
            evaluacion.Fecha = FechaDateTimePicker1.Value;
            evaluacion.Estudiantes = EstudianteTextBox.Text;
            float logrado= evaluacion.Logrado = Convert.ToSingle(LogradoTextBox.Text);
            
            evaluacion.Perdido= Convert.ToSingle(PerdidoTextBox.Text);

            evaluacion.Valor= Convert.ToSingle(ValorTextBox.Text);
            return evaluacion;
     
        }
        public void LlenaCampo(Evaluacion evaluacion)
        {
          
            FechaDateTimePicker1.Value= evaluacion.Fecha  ;
            EstudianteTextBox.Text = evaluacion.Estudiantes;
            float logrado = Convert.ToSingle(LogradoTextBox.Text = evaluacion.Logrado.ToString());
           float  perdido = Convert.ToSingle(PerdidoTextBox.Text = evaluacion.Perdido.ToString());
           float valor = Convert.ToSingle(ValorTextBox.Text = evaluacion.Valor.ToString());
            
                
          

        }
  

            private bool Validar()
            {
                bool paso = true;
               errorProvider1.Clear();

                if (string.IsNullOrWhiteSpace(IdNumericUpDown.Text))
                {
                   errorProvider1.SetError(IdNumericUpDown, "El campode del ID no puede estar vacio...");
                    IdNumericUpDown.Focus();
                    paso = false;
                }

           
                if (EstudianteTextBox.Text =="")
                {
                    errorProvider1.SetError(EstudianteTextBox, "El campo nombre no puede estar vacio...");
                EstudianteTextBox.Focus();
                    paso = false;
                }
            return paso;
            }
        private bool ExisteEnLaBaseDeDatos()
        {
            Evaluacion evaluacion = EvaluacionBLL.Buscar((int)IdNumericUpDown.Value);
            return (evaluacion != null);
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
           
                errorProvider1.Clear();

                int id;
                int.TryParse(IdNumericUpDown.Text, out id);

                Limpiar();

                if (EvaluacionBLL.Eliminar(id))
                    MessageBox.Show("Eliminado", " Con Exito..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    errorProvider1.SetError(IdNumericUpDown, "No se puede eliminar un estudiante que no existe");
            }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
           Evaluacion evaluacion ;
                bool paso = false;

                if (!Validar())
                    return;
               evaluacion = Llenaclase();

                //determina si es guardar oh modificar

                if (IdNumericUpDown.Value == 0)
                    paso = EvaluacionBLL.Guardar(evaluacion);
                else
                {
                    if (!ExisteEnLaBaseDeDatos())
                    {
                        MessageBox.Show("No se pudo modificar el Estudiante que no existe", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    paso = EvaluacionBLL.Modificar(evaluacion);
                }

                //informar el resultado
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Guardado!!", "Exito.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No fue posible guardar!!", "fallo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Evaluacion evaluacion = new Evaluacion();
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();

            evaluacion = EvaluacionBLL.Buscar(id);

            if (evaluacion!= null)
            {
                MessageBox.Show("Estudiante encontrado.");
                LlenaCampo(evaluacion);

            }
            else
            {
                MessageBox.Show("Estudiante no encontrado.");
            }
        }
    }
    }

