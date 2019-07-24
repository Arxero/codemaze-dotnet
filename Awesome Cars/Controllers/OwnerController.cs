using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Awesome_Cars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : Controller
    {
        public OwnerController(IRepositoryWrapper repoWrapper)
        {
            Repository = repoWrapper;
        }

        private IRepositoryWrapper Repository;


        [HttpGet]
        public IActionResult GetAllOwners()
        {
            var owners = Repository.Owner.GetAllOwners();
            return Ok(owners);
        }

        [HttpGet("{id}")]
        public IActionResult GetOwnerById(int id)
        {
            var owner = Repository.Owner.GetOwnerById(id);
            if (owner == null)
            {
                return NotFound();
            }
            return Ok(owner);
        }

        [HttpGet("{id}/account")]
        public IActionResult GetOwnerByIdWithDetails(int id)
        {
            var owner = Repository.Owner.GetOwnerWithDetails(id);
            if (owner == null)
            {
                return NotFound();
            }
            return Ok(owner);
        }


    }
}
