using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Services.Interface;

namespace SparkJobWebAPI.Controllers
{
    [Route("customerform")]
    [ApiController]
    public class CustomerFormController : ControllerBase
    {
        private readonly IMessageService _iMessageService;

        public CustomerFormController(IMessageService iMessageService)
        {
            _iMessageService = iMessageService;
        }

        [HttpPost("send-message/{companyName}")]
        public async Task<ActionResult<object>> SendMessage([FromForm] MessageToAddDto model, [FromRoute] string companyName)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Not found", "");
                return BadRequest(ModelState);
            }
            //Send the message through injected 
            var response = await _iMessageService.SendMessage(model, companyName);
            if (!response.Item1) return BadRequest(new Response { success = response.Item1, message = response.Item2 });
            return Ok(new Response { success = response.Item1, message = response.Item2 });
        }
    }
}
