using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CosMart.JoyTech.Service.Book;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CosMart.JoyTech.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService bookService;

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                var data = await bookService.GetBook(id);
                return Ok(data);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.GetBaseException());
            }
        }

        [HttpGet("subjects/{subject}")]
        public async Task<IActionResult> GetBooksBySubject(string subject)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.GetBaseException());
            }
        }
    }
}
