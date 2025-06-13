using Microsoft.AspNetCore.Mvc;

namespace EventsApi.Models
{
    public interface IEventRepository
    {
        Task<List<Event>> GetEventsAsync();
        Task<List<Ticket>> GetTicketsByEventID(int eventId);
        Task<List<Event>> GetTopFiveHighestSellingEventsAsync();
        Task<List<Event>> GetTopFiveHighestCountEventsAsync();
    }
}
