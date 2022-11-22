using D3vzDbLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace D3vz_API.Controllers.DBAPI {
    [Route("api/[controller]"), ApiController]
    public class InterQualiController : ControllerBase {

        internal static TUser_TInterQuali[] MakeInterQuali(string[] interesses, D3vzAPI_dbContext db) {
            try {
                var arr = interesses.Select(s => {
                    var interesseFound = db.TInterQuali.Where(e => e.DsLinguagem.ToUpper() == s.ToUpper()).FirstOrDefault();
                    if (interesseFound == null)
                        return new TUser_TInterQuali() { TInterQuali_Navigation = new TInterQuali() { DsLinguagem = s.ToUpper() } };
                    else
                        return new TUser_TInterQuali() { TInterQuali_Navigation = interesseFound };
                }).ToArray();
                return arr;
            } catch {
                throw;
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id) {
            try {
                var db = new D3vzAPI_dbContext();
                db.Remove(id);
                db.SaveChanges();

                return Ok();
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

        [HttpGet("GetById")]
        public IActionResult Get(long id) {
            try {
                var db = new D3vzAPI_dbContext();
                var interquali = (from iq in db.TInterQuali
                                  where iq.IdInterQuali == id
                                  select new {
                                      id = iq.IdInterQuali,
                                      nome = iq.DsLinguagem
                                  }).FirstOrDefault();
                return new JsonResult(interquali);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

        [HttpGet]
        public IActionResult Get(string linguagem) {
            try {
                var db = new D3vzAPI_dbContext();
                var interquali = (from iq in db.TInterQuali
                                  where iq.DsLinguagem.ToUpper() == linguagem.ToUpper()
                                  select new {
                                      id = iq.IdInterQuali,
                                      nome = iq.DsLinguagem
                                  }).FirstOrDefault();
                return new JsonResult(interquali);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

        [HttpGet("GetAll")]
        public IActionResult Get() {
            try {
                var db = new D3vzAPI_dbContext();
                var interquali = (from iq in db.TInterQuali
                                  select new {
                                      id = iq.IdInterQuali,
                                      nome = iq.DsLinguagem
                                  });
                return new JsonResult(interquali);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

    }
}
