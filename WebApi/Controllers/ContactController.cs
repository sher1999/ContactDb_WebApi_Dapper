using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("[Controller]")]
public class ContactController:ControllerBase
{
    private ContactService _contactService;
    public ContactController()
    {
        _contactService=new ContactService();
    }
    [HttpGet("Get")]
    public List<Contact> Contact(){
        return _contactService.GetContact();
    }
    [HttpPost("Add")]
    public bool Add(Contact contact){
        return _contactService.AddContact(contact);
    }
    [HttpPut("Update")]
    public bool Update(Contact contact){
        return _contactService.UpdateContact(contact);
    }
     [HttpDelete("Delete")]
     public bool Delete(int id){
        return _contactService.DeleteContact(id);
     }

     [HttpGet("GetByName")]
     public List<Contact> ByName(string name){
        return _contactService.GetByName(name);
     }
}
