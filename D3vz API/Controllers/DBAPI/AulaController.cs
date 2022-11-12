using D3vzDbLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace D3vz_API.Controllers.DBAPI {
    [ApiController, Route("API/[controller]")]
    public class AulaController : ControllerBase {
        [HttpPost]
        public IActionResult Add(long profId, long alunoId, DateTime datahora, string url) {
            try {
                using var db = new D3vzAPI_dbContext();
                db.TAulas.Add(new TAula() {
                    TProfTUserIdUser = profId,
                    TAlunoTUserIdUser = alunoId,
                    DataHora = datahora,
                    URL = url
                });
                db.SaveChanges();

                return Ok();
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update(long id, DateTime? datahora, string? url) {
            try {
                using var db = new D3vzAPI_dbContext();
                var aula = db.TAulas.Find(id);
                if (aula == null)
                    return NotFound(new JsonResult(new {
                        Erro = "Aula não encontrada."
                    }));
                if (datahora != null) aula.DataHora = datahora.Value;
                if (url != null) aula.URL = url;
                db.SaveChanges();

                return Ok();
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id) {
            try {
                using var db = new D3vzAPI_dbContext();
                var aula = db.TAulas.Find(id);
                if (aula == null)
                    return NotFound(new JsonResult(new {
                        Erro = "Aula não encontrada."
                    }));
                db.TAulas.Remove(aula);
                db.SaveChanges();

                return Ok();
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        public IActionResult Get(long id) {
            try {
                using var db = new D3vzAPI_dbContext();
                var aula = db.TAulas.Find(id);
                if (aula == null)
                    return NotFound(new JsonResult(new {
                        Erro = "Aula não encontrada."
                    }));

                return new JsonResult(aula);
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByUser")]
        public IActionResult Get(long userId, string discriminacao) {
            try {
                using var db = new D3vzAPI_dbContext();
                switch (discriminacao.ToLower()) {
                    case "aluno": {
                            var aulas = from aula in db.TAulas
                                        where aula.TAlunoTUserIdUser == userId
                                        select new {
                                            aula.IdAula,
                                            AlunoId = aula.TAlunoTUserIdUser,
                                            ProfessorId = aula.TProfTUserIdUser,
                                            aula.DataHora,
                                            aula.URL
                                        };
                            if (aulas == null)
                                return NotFound(new JsonResult(new {
                                    Erro = "Aula não encontrada."
                                }));

                            return new JsonResult(aulas);
                        }
                    case "prof": {
                            var aulas = from aula in db.TAulas
                                        where aula.TProfTUserIdUser == userId
                                        select new {
                                            aula.IdAula,
                                            AlunoId = aula.TAlunoTUserIdUser,
                                            ProfessorId = aula.TProfTUserIdUser,
                                            aula.DataHora,
                                            aula.URL
                                        };
                            if (aulas == null)
                                return NotFound(new JsonResult(new {
                                    Erro = "Aula não encontrada."
                                }));

                            return new JsonResult(aulas);
                        }
                    default:
                        return BadRequest("Discriminação incorreta.");
                }
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetByInterlocutores")]
        public IActionResult Get(long professorId, long alunoId) {
            throw new NotImplementedException();
        }
    }
}
