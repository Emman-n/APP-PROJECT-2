using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

  
    ///general structure for a controller that has a database table in this case "users"
    //follow the same structure to add more controllers

    //when we ingered from another class we get all its attributes (apicontroller/routeapi...) 
    //also we get all metods and other stuff from  the derived class
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task < ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await  _context.Users.ToListAsync();

        }




        [Authorize]
        [AllowAnonymous]
        //api/users/id
        [HttpGet("{id}")]
        public async Task < ActionResult<AppUser>> GetUser(int id)
        {
            ////find id from the database            
            return await _context.Users.FindAsync(id);

        }

    }


}