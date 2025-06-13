using EventsApi.Context;
using EventsApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventsApi.Services
{
    public class EventService : IEventService
    {
        private readonly EventsContext _context;

        public EventService(EventsContext context)
        {
            _context = context;
        }

        public async Task<List<Event>> GetEventsAsync()
        {
            return await _context.Events.ToListAsync();
        }
    }
}
