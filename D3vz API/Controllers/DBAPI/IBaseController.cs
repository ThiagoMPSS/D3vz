using Microsoft.AspNetCore.Mvc;

namespace D3vz_API.Controllers.DBAPI {
    public interface IBaseController {
        IActionResult Add(string nm_user, string email, string senha, string cpf, DateTime dt_nasc, string[] interesses);
        IActionResult Delete(int Id);
        IActionResult Get(long id);
        IActionResult Get(string email);
        IActionResult Update(long id, string? nm_user, string? email, string? senha, string? cpf, DateTime? dt_nasc, string[] interesses);
    }
}