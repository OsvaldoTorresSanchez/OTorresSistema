using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Plantel
    {
        public static ML.Result GetbyIdSistema(int IdSistema)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AlumnoEntities context = new DL.AlumnoEntities())
                {
                    var resultQuery = context.PlatenlGetByIdSistema(IdSistema).ToList();


                    if (resultQuery != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in resultQuery)
                        {
                            ML.Plantel plantel = new ML.Plantel();
                            plantel.IdPlantel = obj.IdPlantel;
                            plantel.Nombre = obj.Nombre;
                            plantel.Sistema = new ML.Sistema();
                            plantel.Sistema.IdSistema = obj.IdSistema.Value;

                            result.Objects.Add(plantel);
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
