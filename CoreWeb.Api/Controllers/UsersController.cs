using CoreWeb.Application.Interfaces;
using CoreWeb.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreWeb.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserAppService service;

        public UsersController(IUserAppService iservice)
        {
            service = iservice;
        }

        [HttpPost]
        public IActionResult Post(UserViewModel user)
        {
            var newUser = service.Add(user);
            return Created("$/api/users/{ newUser.Id}", newUser);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, UserViewModel person)
        {
            if (service.GetById(id) == null)
                return NotFound();
            else
            {
                service.Update(person);
                return NoContent();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (service.GetById(id) == null)
                return NotFound();
            else
            {
                service.Remove(id);
                return NoContent();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = service.GetById(id);
            if (user == null)
                return NotFound();
            else
                return Ok(user);
        }

        //[HttpDelete("{id}/image/{idtypeimage}")]
        //public IActionResult DeleteUserImage(int id, int idtypeimage)
        //{
        //    if (service.GetById(id) == null)
        //        return NotFound();
        //    else
        //    {
        //        service.RemoveUserImage(id, idtypeimage);
        //        return NoContent();
        //    }
        //}
    }
}
