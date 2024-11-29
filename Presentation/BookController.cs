using Entitites.Models;
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

    [HttpGet("GetAllBook")]
    public IActionResult GetAllBook()
    {
        var books=_manager.bookService.GetAllBook(false);
        return Ok(books);
    }

    [HttpPost("GetOneBook/{id}")]
    public IActionResult GetOneBook([FromRoute(Name ="id")]int id,[FromBody]bool trackChange)
    {
        var book=_manager.bookService.GetOneBook(id,trackChange);
        return Ok(book);
    }

    [HttpPost("CreateOneBook")]
    public IActionResult CreateOneBook([FromBody]BookModel book)
    {
       
        var create=_manager.bookService.CreateOneBook(book);
        if(create is null)
            return NotFound($"{book.bookName} not created ");
        return Ok($"{book.bookName} is successfully created");
       
    }

    [HttpPatch("UpdateOneBook/{id}")]
    public IActionResult UpdateOneBook([FromRoute(Name ="id")]int id, [FromBody]bool trackChange)
    {
       
        var isUpdate= _manager.bookService.UpdateOneBook(id,trackChange);
        if(isUpdate)
            return Ok("Book Updated");
        return NotFound("This book not found");

    }

    [HttpDelete("DeleteOneBook/{id}")]
    public IActionResult DeleteOneBook([FromRoute(Name ="id")]int id,[FromBody]bool trackChange)
    {
        try
        {
            var isDelete=_manager.bookService.DeleteOneBook(id,trackChange);
            if(isDelete)
                return Ok("Book Deleted");
            return NotFound("Book Not Found");
        }catch(Exception e)
        {
            return BadRequest(e.Message.ToString());
        }
    }

    

}
