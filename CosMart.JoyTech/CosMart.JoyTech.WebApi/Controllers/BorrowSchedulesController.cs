using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CosMart.JoyTech.Service.BorrowSchedule;
using CosMart.JoyTech.Service.BorrowSchedule.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CosMart.JoyTech.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowSchedulesController : ControllerBase
    {
        private readonly IBorrowScheduleService borrowScheduleService;

        public BorrowSchedulesController(IBorrowScheduleService borrowScheduleService)
        {
            this.borrowScheduleService = borrowScheduleService;
        }

        // GET: api/<BorrowSchedulesController>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] DateTime date)
        {
            try
            {
                var data = await borrowScheduleService.GetBorrowSchedule(date);
                return Ok(data);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.GetBaseException());
            }
        }

        // GET api/<BorrowSchedulesController>/5
        [HttpGet("BookId/{bookId}")]
        public async Task<IActionResult> Get([FromRoute] string bookId)
        {
            try
            {
                var data = await borrowScheduleService.GetBorrowSchedule(bookId);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.GetBaseException());
            }
        }

        // POST api/<BorrowSchedulesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BorrowScheduleRequestDto borrowScheduleDto)
        {
            try
            {
                await borrowScheduleService.ScheduleBorrowBook(borrowScheduleDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.GetBaseException());
            }
        }
    }
}
