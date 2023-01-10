using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleAppToWebApi.Controllers
{


    [ApiController]
    [Route("[Controller]/[action]")]

    public class ValuesController : ControllerBase
    {
       [Route("~/api/get-all")]
        public string GetAll()
        {
            return "Hello From GetAll";
        }
        [Route("api/get-all-author")]

        public string GetAllAuthor()
        {
            return "Hello From GetAllAuthor";
        }
        //[Route("books/{id}")]
        [Route("{id}")]
        public string GetById(int id)
        {
            return "hello " + id;
        }
        [Route("books/{id}/author/{authorId}")]

        public string GetAudthorAddressById(int id, int authorId)
        {
            return "hello author address " + id + " " + authorId;
        }
        //[Route("Search")]
        public string SearchBooks(int id, int authId, string name, int rating, int price) 
        {

            return "hello search book";

        }
    }
}
