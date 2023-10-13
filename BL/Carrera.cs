using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Carrera
    {
        public static ML.Result GetbyIdPlantel(int IdPlantel)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AlumnoEntities context = new DL.AlumnoEntities())
                {
                    var resultQuery = context.CarreraGetByIdPlantel(IdPlantel).ToList();


                    if (resultQuery != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in resultQuery)
                        {
                            ML.Carrera carrera = new ML.Carrera();
                            carrera.IdCarrera = obj.IdCarrera;
                            carrera.Nombre = obj.Nombre;
                            carrera.Plantel = new ML.Plantel();
                            carrera.Plantel.IdPlantel = obj.IdPlantel.Value;

                            result.Objects.Add(carrera);
                            result.Correct = true;
                        }
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrio un error la tabla no contiene informacion ";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
    }
}
