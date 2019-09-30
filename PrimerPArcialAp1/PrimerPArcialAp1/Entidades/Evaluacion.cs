using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPArcialAp1.Entidades
{
    public class Evaluacion { 
    [Key]
        public int EvaluacionId { get; set; }
        public string Estudiantes { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Valor { get; set; }
        public decimal Logrado { get; set; }
        public decimal Perdido { get; set; }
        public int Pronostico { get; set; }

        public Evaluacion()
        {
            EvaluacionId = 0;
            Estudiantes = string.Empty;
            Pronostico = 0;
            Fecha = DateTime.Now;
            Valor = 0;
            Logrado = 0;
            Perdido = 0;
        }
    }
}
