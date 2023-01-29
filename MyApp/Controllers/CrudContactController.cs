using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
namespace CrudContactController;
using MYAPP.Models;
using MYAPP.DAL;
using System;
using System.Collections;

[ApiController]
[Route("api/[controller]")]

public class CrudContactController : ControllerBase
{
    private readonly ILogger<CrudContactController> _logger;

    public CrudContactController(ILogger<CrudContactController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [EnableCors()]
    public IEnumerable<Crud_Contact> GetAllContacts()
    {
        List<Crud_Contact> contacts = CrudContactAccess.GetAllContact();
        return contacts;
    }

    [Route("{id}")]
    [HttpGet]
    [EnableCors()]
    public ActionResult<Crud_Contact> GetOneContact(int id)
    {
        Crud_Contact contact = CrudContactAccess.GetContactById(id);
        return contact;
    }

    [HttpPost]
    [EnableCors()]
    public IActionResult InsertNewContact(Crud_Contact contact)
    {
        CrudContactAccess.SaveNewContact(contact);
        return Ok(new { message = "Contact created" });
    }

    [Route("{id}")]
    [HttpDelete]
    [EnableCors()]
    public ActionResult<Crud_Contact> DeleteContact(int id)
    {
         CrudContactAccess.DeleteContactById(id);
         return Ok(new { message = "Contact deleted" });
    }
}