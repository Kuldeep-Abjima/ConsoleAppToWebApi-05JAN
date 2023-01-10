using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleAppToWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(10)}")]
        public string GetById(int id)
        {
            return "hello by int " + id;
        }
        [Route("{id}")]
        public string GetStringById(string id)
        {
            return "hello by stri " + id;
        }
        [Route("{id:regex(a(b|c))}")]
        public string GetByIdRegex(string id)
        {
            return "hello by stri " + id;
        }
    }
}
