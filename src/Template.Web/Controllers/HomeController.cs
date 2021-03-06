﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Template.Web.Model.Entities;
using Template.Web.Repositories;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Template.Web.Api
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private UsersRepository UsersRepository { get; set; }
        public PersistentRepository PersistentRepository { get; set; }

        public HomeController(UsersRepository usersRepository, PersistentRepository persistentRepository)
        {
            UsersRepository = usersRepository;
            PersistentRepository = persistentRepository;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<object> Get()
        {
            return UsersRepository.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
