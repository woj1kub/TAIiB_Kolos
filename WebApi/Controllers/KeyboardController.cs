using Microsoft.AspNetCore.Mvc;
using WebApi.BLL;
using WebApi.DTO;
using WebApi.Model;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KeyboardController : ControllerBase
    {
        private IService service = new Service();

        [HttpGet]
        public ActionResult<IEnumerable<Keyboards>> GetKeyboards()
        {
            return Ok(service.get());
        }

        [HttpPost]
        public ActionResult<int> AddKeyboard([FromBody] KeyboardDTO newKeyboard)
        {
            return Ok(service.add(newKeyboard));
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteKeyboard(int id)
        {
            return Ok(service.remove(id));
        }
    }
}
