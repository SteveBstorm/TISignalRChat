using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TISignalRChat.DataContext;

namespace TISignalRChat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly FakeChatDB fakeChatDB;

        public ChatController(FakeChatDB fakeChatDB)
        {
            this.fakeChatDB = fakeChatDB;
        }

        [HttpGet]
        public IActionResult GetMessage()
        {
            return Ok(fakeChatDB.GetMessages());
        }
    }
}
