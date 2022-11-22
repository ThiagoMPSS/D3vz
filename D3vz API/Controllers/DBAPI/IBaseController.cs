using Microsoft.AspNetCore.Mvc;

namespace D3vz_API.Controllers.DBAPI {
    public interface IBaseController {
        IActionResult Add(object jsonObject);
        IActionResult Update(object jsonObject);
        IActionResult Delete(int Id);
        IActionResult Get(long id);
        IActionResult Get(string email, string discriminacao);
    }
}