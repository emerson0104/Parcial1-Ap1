using PrimerPArcialAp1.DAL;
using PrimerPArcialAp1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPArcialAp1.BLL
{
   public class EvaluacionBLL
    {
        public static bool Guardar(Evaluacion evaluacion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Evaluacion.Add(evaluacion) != null)

                    paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();//siempre hay que cerrar la conexion
            }
            return paso;
        }
        //este metodo modifica
        public static bool Modificar(Evaluacion evaluacion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(evaluacion ).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();

            }
            return paso;
        }

        //este metodo eliminar una entidad en la base de datos
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Evaluacion.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        //este metodo para buscar una persona
        public static Evaluacion Buscar(int id)
        {
            Contexto db = new Contexto();
            Evaluacion evaluacion = new Evaluacion();
            try
            {
               evaluacion= db.Evaluacion.Find(id);

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                db.Dispose();
            }
            return evaluacion;

        }

        public static decimal CalcularPerdido(decimal valor, decimal logrado)
        {
            return valor - logrado;
        }
    }
}
    

