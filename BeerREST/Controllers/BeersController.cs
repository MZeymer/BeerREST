﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beer_Testing;
using BeerREST.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BeerREST.Controllers
{
    [Route("beers")]
    [ApiController]
    public class BeersController : ControllerBase
    {

        private readonly BeerManager _manager = new BeerManager();

        // GET: api/<BeersController>
        [HttpGet]
        public IEnumerable<Beer> Get([FromQuery] string name, [FromQuery] string sortBy)
        {
            return _manager.GetAll(name, sortBy);
        }

        // GET api/<BeersController>/5
        [HttpGet("{id}")]
        public Beer Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<BeersController>
        [HttpPost]
        public Beer Post([FromBody] Beer value)
        {
            return _manager.Add(value);
        }

        // PUT api/<BeersController>/5
        [HttpPut("{id}")]
        public Beer Put(int id, [FromBody] Beer value)
        {
            return _manager.Update(id, value);
        }

        // DELETE api/<BeersController>/5
        [HttpDelete("{id}")]
        public Beer Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
