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
        public float Valor { get; set; }
        public float Logrado { get; set; }
        public float Perdido { get; set; }
        public string Pronostico { get; set; }

        public Evaluacion()
        {
            EvaluacionId = 0;
            Estudiantes = string.Empty;
            Pronostico = string.Empty;
            Fecha = DateTime.Now;
            Valor = 0;
            Logrado = 0;
        }
    }
}
