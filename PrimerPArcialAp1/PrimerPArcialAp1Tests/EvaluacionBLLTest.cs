using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimerPArcialAp1.BLL;
using PrimerPArcialAp1.DAL;
using PrimerPArcialAp1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPArcialAp1Tests
{[TestClass]
  public  class EvaluacionBLLTest
    {
       [TestMethod()]
       public void GuardarTest() {
            bool paso;
            Evaluacion evaluacion = new Evaluacion();
            evaluacion.EvaluacionId = 0;
            evaluacion.Perdido = 12;
            evaluacion.Logrado = 2;
            evaluacion.Valor = 14;
            evaluacion.Estudiantes = "jose jose";
            evaluacion.Fecha = DateTime.Now;
            paso = EvaluacionBLL.Guardar(evaluacion);
            Assert.AreEqual(paso, true);
            
        }
        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Evaluacion evaluacion = new Evaluacion();
            evaluacion.EvaluacionId = 1;
            evaluacion.Perdido = 13;
            evaluacion.Logrado = 2;
            evaluacion.Valor = 14;
            evaluacion.Estudiantes = "jose jos";
            evaluacion.Fecha = DateTime.Now;
            paso = EvaluacionBLL.Modificar(evaluacion);
            Assert.AreEqual(paso, true);

        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            int id=1;
            Evaluacion evaluacion = new Evaluacion();
            evaluacion.EvaluacionId = id;
            evaluacion.Perdido = 12;
            evaluacion.Logrado = 2;
            evaluacion.Valor = 14;
            evaluacion.Estudiantes = "jose jose";
            evaluacion.Fecha = DateTime.Now;
            paso = EvaluacionBLL.Eliminar(id);
            Assert.AreEqual(paso, true);

        }
       
    }
}
