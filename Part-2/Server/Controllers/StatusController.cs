using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Server.Domain;
using Server.Repository;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusController
        : ControllerBase
    {
        private readonly InMemoryDatabase _inMemoryDatabase;

        public StatusController(InMemoryDatabase inMemoryDatabase)
        {
            _inMemoryDatabase = inMemoryDatabase ?? throw new System.ArgumentNullException(nameof(inMemoryDatabase));
        }

        [HttpGet]
        public ActionResult<List<StatusMessage>> GetStatus()
        {
            return Ok(_inMemoryDatabase.StatusMessages);
        }

        [HttpPost("like/{statusId}")]
        public ActionResult<StatusMessage> Like([FromRoute]Guid statusId, [FromBody]Person person)
        {
            var statusMessage = _inMemoryDatabase.StatusMessages.FirstOrDefault(s => s.Id == statusId);
            statusMessage.Like(person.Name);
            return Ok(statusMessage);
        }

        [HttpPost("comment/{statusId}")]
        public ActionResult<StatusMessage> Comment(
            [FromRoute]Guid statusId, 
            [FromBody]Comment comment)
        {
            var statusMessage = _inMemoryDatabase.StatusMessages.FirstOrDefault(s => s.Id == statusId);
            statusMessage.Comment(comment);
            return Ok(statusMessage);
        }
    }
}