using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class SistemaController : Controller
    {
        // GET: Sistema
        [HttpGet]
        public ActionResult GetAll()
        {

            ML.Sistema sistema = new ML.Sistema();
            //sistema.Sistemas = new List<object>();

            ML.Grupo grupo = new ML.Grupo();
            grupo.Grupos = new List<object>();

            ML.Result resultGrupo = BL.Grupo.GetbyIdCarrera(sistema.IdSistema);
            grupo.Grupos = resultGrupo.Objects;

            //ML.Result result = BL.Sistema.GetAllEF();
            //sistema.Sistemas = result.Objects;

            return View(grupo);
        }

        public JsonResult PlatenlGetByIdSistema(int IdSistema)
        {
            ML.Result result = BL.Plantel.GetbyIdSistema(IdSistema);

            return Json(result.Objects);
        }

        public JsonResult CarreraGetByIdPlantel(int IdPlantel)
        {
            ML.Result result = BL.Carrera.GetbyIdPlantel(IdPlantel);

            return Json(result.Objects);
        }

        public JsonResult GrupoGetByIdCarrera(int IdCarrera)
        {
            ML.Result result = BL.Grupo.GetbyIdCarrera(IdCarrera);

            return Json(result.Objects);
        }
    }
}