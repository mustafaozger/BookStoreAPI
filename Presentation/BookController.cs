using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace Presentation;

    [ApiController]
    [Route("Book")]
public class BookController:ControllerBase
{
    private readonly IServiceManager _manager;

  public  BookController(IServiceManager manager)
    {
        _manager=manager;
    }

    [HttpGet]
    public IActionResult GetAllBook()
    {
    
        try{
            var books=_manager.bookService.GetAllBook(false);
            return Ok(books);

        }catch(Exception e ){
            return BadRequest(e.Message.ToString());
        }

    }
    

}
