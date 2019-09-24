using PrimerPArcialAp1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPArcialAp1.DAL
{
    public class Contexto:DbContext
    {
    public  DbSet<Evaluacion> Evaluacion { get; set; }
        public Contexto():base("conStr")
        {

        }
    }
}
