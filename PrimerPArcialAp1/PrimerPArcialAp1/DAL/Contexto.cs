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
        public Contexto():base("conStr")
        {

        }
    }
}
