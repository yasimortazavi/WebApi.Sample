﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Bugeto.Models.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Bugeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly TodoRepository todoRepository;
        public ToDoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        // GET: api/<ToDoController>
        [HttpGet]
        public IActionResult Get()
        {
            var todoList = todoRepository.GetAll();
            return Ok(todoList);
            //return new string[] { "value1", "value2" };
        }

        // GET api/<ToDoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ToDoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ToDoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ToDoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
