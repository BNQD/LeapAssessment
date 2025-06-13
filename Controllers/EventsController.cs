using EventsApi.Context;
using EventsApi.Models;
using EventsApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace EventsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventsService;

        public EventsController(IEventService eventsService)
        {
            _eventsService = eventsService;
        }

        [HttpGet(Name = "GetEvents")]
        public async Task<IEnumerable<Event>> GetEvents()
        {
            var events = await _eventsService.GetEventsAsync();
            return events;
        }
    }
}
