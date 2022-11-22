using D3vzDbLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace D3vz_API.Controllers.DBAPI {
    [ApiController, Route("API/[controller]")]
    public partial class UserController : ControllerBase {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger) {
            _logger = logger;
        }

        internal virtual IActionResult Add(string discriminacao, string nm_user, string descricao, string email, string senha, string cpf, DateTime dt_nasc,
                string? foto, string[]? interquali) {
            try {
                TProf? prof = null;
                TAluno? aluno = null;

                if (!Regex.IsMatch(email, "^\\w+([\\.-]?\\w+)*@\\w+([\\.-]?\\w+)*(\\.\\w{2,3})+$"))
                    return new JsonResult(new {
                        Erro = "Endereço de email inválido."
                    });

                switch (discriminacao) {
                    case "prof":
                        prof = new TProf();
                        break;
                    case "aluno":
                        aluno = new TAluno();
                        break;
                    default:
                        return BadRequest(new JsonResult("Discriminação inválida"));
                }

                using var db = new D3vzAPI_dbContext();
                var user = new TUser() {
                    Discriminacao = prof != null ? "prof" : "aluno",
                    NmUsuario = nm_user,
                    Descricao = descricao,
                    DsEmail = email,
                    DsSenha = senha,
                    NrCpf = cpf,
                    DtNascimento = dt_nasc,
                    UrlFoto = foto,
                    TProf = prof,
                    TAluno = aluno
                };
                if (interquali != null)
                    user.TUser_TInterQuali = InterQualiController.MakeInterQuali(interquali, db);
                db.TUsers.Add(user);
                db.SaveChanges();
                return StatusCode((int)HttpStatusCode.OK);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody] JUser user) {
            try {
                return Add(user!.Discriminacao, user!.Nome, user!.Descricao, user!.Email, user!.Senha, cpf: user!.Cpf,
                    dt_nasc: user!.Nascimento, user!.Foto, user!.Interquali);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

        internal virtual IActionResult Update(long id, string discriminacao, string? nm_user, string? descricao, string? email, string? senha, string? cpf,
                DateTime? dt_nasc, string? foto, string? dias, string? horarios, string[]? interesses) {
            try {
                TProf? prof = null;
                TAluno? aluno = null;

                using var db = new D3vzAPI_dbContext();
                var user = db.TUsers
                    .Where(e => e.IdUser == id)
                    .Include(e => e.TProf)
                    .Include(e => e.TAluno)
                    .Include(e => e.TUser_TInterQuali)
                    .ThenInclude(e => e.TInterQuali_Navigation)
                    .FirstOrDefault();

                switch (discriminacao) {
                    case "prof":
                        var diasHorariosBool = TProf.ConverterHorariosDias(horarios!, dias!);
                        var diasBool = diasHorariosBool.dias;
                        var horariosBool = diasHorariosBool.horarios;

                        prof = new TProf() {
                            Dias = diasBool!,
                            Horarios = horariosBool!
                        };
                        break;
                    case "aluno":
                        aluno = new TAluno();
                        break;
                    default:
                        return BadRequest(new JsonResult("Discriminação inválida"));
                }

                if (user == null)
                    return StatusCode((int)HttpStatusCode.NotFound, new JsonResult(new {
                        Erro = "Cadastro não encontrado."
                    }));

                if (!string.IsNullOrEmpty(nm_user)) user.NmUsuario = nm_user;
                if (!string.IsNullOrEmpty(descricao)) user.Descricao = descricao;
                if (!string.IsNullOrEmpty(email)) user.DsEmail = email;
                if (!string.IsNullOrEmpty(senha)) user.DsSenha = senha;
                if (!string.IsNullOrEmpty(cpf)) user.NrCpf = cpf;
                if (dt_nasc != null) user.DtNascimento = dt_nasc.Value;
                if (!string.IsNullOrEmpty(foto)) user.UrlFoto = foto;
                if (prof != null) user.TProf = prof;
                if (aluno != null) user.TAluno = aluno;
                if (interesses != null) {
                    var remover = user.TUser_TInterQuali.Where(e => !interesses.Contains(e.TInterQuali_Navigation.DsLinguagem));
                    var adicionar = interesses.Where(e => user.TUser_TInterQuali.Where(e1 => e1.TInterQuali_Navigation.DsLinguagem == e).FirstOrDefault() == null);
                    foreach (var item in remover)
                        user.TUser_TInterQuali.Remove(item);
                    foreach (var item in adicionar)
                        user.TUser_TInterQuali.Add(InterQualiController.MakeInterQuali(new string[] { item }, db).First());
                }
                if (prof != null) {
                    if (prof.Dias != null)
                        user.TProf!.Dias = prof.Dias;
                    if (prof.Horarios != null)
                        user.TProf!.Horarios = prof.Horarios;
                }

                db.SaveChanges();

                return StatusCode((int)HttpStatusCode.OK);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

        [HttpPut]
        public virtual IActionResult Update([FromBody] JUser user) {
            try {
                return Update(user!.Id, user!.Discriminacao, user!.Nome, user!.Descricao, user!.Email, user!.Senha, user!.Cpf,
                    user!.Nascimento, user!.Foto, user!.Dias, user!.Horarios, user!.Interquali);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

        [HttpDelete]
        public virtual IActionResult Delete(int Id) {
            try {
                using var db = new D3vzAPI_dbContext();
                var user = db.TUsers
                    .Where(e => e.IdUser == Id)
                    .Include(e => e.TProf)
                    .Include(e => e.TAluno)
                    .FirstOrDefault();

                if (user == null)
                    return StatusCode((int)HttpStatusCode.NotFound, new JsonResult(new {
                        Erro = "Cadastro não encontrado."
                    }));

                if (user.TAluno != null)
                    db.TAlunos.Remove(user.TAluno);
                else if (user.TProf != null)
                    db.TProfs.Remove(user.TProf);

                db.TUsers.Remove(user);
                db.SaveChanges();
                return StatusCode((int)HttpStatusCode.OK);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

        [HttpGet("GetById")]
        public virtual IActionResult Get(long id) {
            try {
                using var db = new D3vzAPI_dbContext();

                var user = (from User in db.TUsers
                                .Include(e => e.TProf)
                                .Include(e => e.TAluno)
                                .Include(e => e.TUser_TInterQuali)
                                .ThenInclude(e => e.TInterQuali_Navigation)
                                .Where(e => e.IdUser == id)
                            select new {
                                id = User.IdUser,
                                discriminacao = User.Discriminacao,
                                nome = User.NmUsuario,
                                descricao = User.Descricao,
                                email = User.DsEmail,
                                cpf = User.NrCpf,
                                nascimento = User.DtNascimento,
                                foto = User.UrlFoto,
                                interquali = User.TUser_TInterQuali.Select(e => e.TInterQuali_Navigation.DsLinguagem),
                                dias = User.TProf!.Dias,
                                horarios = User.TProf!.Horarios
                            }).FirstOrDefault();

                return new JsonResult(user);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

        [HttpGet]
        public virtual IActionResult Get(string email, string discriminacao) {
            try {
                using var db = new D3vzAPI_dbContext();

                var user = (from User in db.TUsers
                                .Include(e => e.TProf)
                                .Include(e => e.TAluno)
                                .Include(e => e.TUser_TInterQuali)
                                .ThenInclude(e => e.TInterQuali_Navigation)
                                .Where(e => e.DsEmail == email && e.Discriminacao == discriminacao)
                            select new {
                                id = User.IdUser,
                                discriminacao = User.Discriminacao,
                                nome = User.NmUsuario,
                                descricao = User.Descricao,
                                email = User.DsEmail,
                                cpf = User.NrCpf,
                                nascimento = User.DtNascimento,
                                foto = User.UrlFoto,
                                interquali = User.TUser_TInterQuali.Select(e => e.TInterQuali_Navigation.DsLinguagem),
                                dias = User.TProf!.Dias,
                                horarios = User.TProf!.Horarios
                            }).FirstOrDefault();

                return new JsonResult(user);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

        [HttpGet("GetAll")]
        public virtual IActionResult Get(string discriminacao) {
            try {
                using var db = new D3vzAPI_dbContext();
                var users = (from User in db.TUsers
                                .Include(e => e.TProf)
                                .Include(e => e.TAluno)
                                .Include(e => e.TUser_TInterQuali)
                                .ThenInclude(e => e.TInterQuali_Navigation)
                                .Where(e => e.Discriminacao == discriminacao)
                             select new {
                                 id = User.IdUser,
                                 discriminacao = User.Discriminacao,
                                 nome = User.NmUsuario,
                                 descricao = User.Descricao,
                                 email = User.DsEmail,
                                 cpf = User.NrCpf,
                                 nascimento = User.DtNascimento,
                                 foto = User.UrlFoto,
                                 interquali = User.TUser_TInterQuali.Select(e => e.TInterQuali_Navigation.DsLinguagem),
                                 dias = User.TProf!.Dias,
                                 horarios = User.TProf!.Horarios
                             }).ToArray();
                return new JsonResult(users);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

        internal virtual IActionResult Auth(string email, string senha, string discriminacao) {
            try {
                var db = new D3vzAPI_dbContext();
                var userExists = (from user in db.TUsers
                                  where user.DsEmail == email
                                     && user.DsSenha == senha
                                  && user.Discriminacao == discriminacao
                                  select new {
                                      user.IdUser,
                                      user.Discriminacao
                                  }).ToArray().FirstOrDefault();
                if (userExists == null)
                    return NotFound(new { Auth = false });

                return new JsonResult(new { Auth = true, Id = userExists.IdUser, userExists.Discriminacao });
            } catch (Exception ex) {
                return BadRequest(ex);
            }
        }

        [HttpPost("Auth")]
        public IActionResult Auth([FromBody] JUser user) {
            try {
                return Auth(user.Email, user.Senha, user.Discriminacao);
            } catch (Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }

        internal virtual IActionResult AuthGoogle(string code, string discriminacao) {
            try {
                var db = new D3vzAPI_dbContext();
                var userExists = (from user in db.TUsers
                                  where user.GoogleAuth == code
                                    && user.Discriminacao == discriminacao
                                  select new {
                                      user.IdUser,
                                      user.Discriminacao
                                  }).ToArray().FirstOrDefault();
                if (userExists == null)
                    return NotFound(new { Auth = false });

                return new JsonResult(new { Auth = true, Id = userExists.IdUser, userExists.Discriminacao });
            } catch (Exception ex) {
                return BadRequest(ex);
            }
        }

        [HttpPost("AuthGoogle")]
        public IActionResult AuthGoogle([FromBody] JUser user) {
            try {
                return AuthGoogle(user.GoogleAuth!, user.Discriminacao);
            } catch(Exception ex) {
                return StatusCode((int)HttpStatusCode.InternalServerError, new JsonResult(ex));
            }
        }
    }
}