using Microsoft.AspNetCore.Mvc;
using ProEvents.API.Data.Contexts;
using ProEvents.API.Models;

namespace ProEvents.API.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class EventsController : ControllerBase
{
    private readonly DataContext _context;
    private readonly ILogger<EventsController> _logger;

    public EventsController(DataContext context, ILogger<EventsController> logger)
    {
        _context = context;
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Event> Get()
    {
        return _context.Events;
    }

    [HttpGet("{id}")]
    public Event Get(int id)
    {
        return _context.Events.FirstOrDefault(e => e.Id == id);
    }
}
