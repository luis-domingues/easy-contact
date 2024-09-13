using Microsoft.AspNetCore.Mvc;
using MvcProject.Context;

namespace MvcProject.Controllers;

public class ContactController : Controller
{
    private readonly AgendaContext _context;

    public ContactController(AgendaContext context)
    {
        _context = context;
    }
        
    public IActionResult Index()
    {
        var contacts = _context.Contacts.ToList();
        return View(contacts);
    }
}