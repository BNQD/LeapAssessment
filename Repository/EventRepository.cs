using EventsApi.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventsApi.Models
{
    public class EventRepository : IEventRepository
    {
        private readonly EventsContext _context;
        public EventRepository(EventsContext context)
        {
            _context = context;
        }
        public async Task<List<Event>> GetEventsAsync()
        {
            return await _context.Events.ToListAsync();
        }
    }
}
