using Microsoft.AspNetCore.Mvc;
using MvcProject.Context;
using MvcProject.Models;

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
        var contacts = _context.Contacts?.ToList();
    
        if (contacts == null || !contacts.Any())
        {
            return View(new List<Contact>());
        }

        return View(contacts);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Contact contact)
    {
        if(ModelState.IsValid)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        
        return View(contact);
    }

    public IActionResult Edit(int id)
    {
        var contact = _context.Contacts.Find(id);
        if (contact == null)
        {
            return NotFound();
        }
        return View(contact);
    }

    [HttpPost]
    public IActionResult Edit(Contact contact)
    {
        var dbContact = _context.Contacts.Find(contact.Id);

        if (dbContact != null)
        {
            dbContact.Name = contact.Name;
            dbContact.Number = contact.Number;
            dbContact.IsActive = contact.IsActive;

            _context.Contacts.Update(dbContact);
        }

        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Details(int id)
    {
        var contact = _context.Contacts.Find(id);

        if (contact == null)
        {
            return RedirectToAction(nameof(Index));
        }

        return View(contact);
    }

    public IActionResult Delete(int id)
    {
        var contact = _context.Contacts.Find(id);

        if (contact == null)
        {
            return RedirectToAction(nameof(Index));
        }

        return View(contact);
    }

    [HttpPost]
    public IActionResult Delete(Contact contact)
    {
        var dbContact = _context.Contacts.Find(contact.Id);

        if (dbContact != null) _context.Contacts.Remove(dbContact);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}