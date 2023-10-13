using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Grupo
    {
        public static ML.Result GetbyIdCarrera(int IdCarrera)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AlumnoEntities context = new DL.AlumnoEntities())
                {
                    var resultQuery = context.GrupoGetByIdCarrera(IdCarrera).ToList();


                    if (resultQuery != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in resultQuery)
                        {
                            ML.Grupo grupo = new ML.Grupo();
                            grupo.IdGrupo = obj.IdGrupo;
                            grupo.Nombre = obj.Nombre;
                            grupo.Cantidad = obj.Cantidad;
                            grupo.Carrera = new ML.Carrera();
                            grupo.Carrera.IdCarrera = obj.IdCarrera.Value;

                            result.Objects.Add(grupo);
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
