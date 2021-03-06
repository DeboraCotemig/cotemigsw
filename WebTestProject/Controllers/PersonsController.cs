﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebTestProject.Models;

namespace WebTestProject.Controllers
{
    [RoutePrefix("v1/persons")]
    public class PersonsController : ApiController
    {

        private string Name { get; set; }
        private static IList<Person> _persons = new List<Person>();

        [Route("{id}/name")]
        [HttpGet]
        public string GetName()

        {
            Name = "Debora";
            return Name;
        }
        [Route("{id}/old")]
        [HttpGet]
        public int GetOld(int id)
        {

            return id;
        }
        [Route("{id}/surname")]
        [HttpGet]
        public string GetSurName(string x, string y)
        {
            return "de Sousa";
        }

        [Route("{id}")]
        [HttpGet]
        public Person GetPersons(int id)
        {
            return _persons[id];
        }

        [Route]
        [HttpGet]
        public IList<Person> GetPersons()
        {
            return _persons;
        }

        [Route]
        [HttpPost]
        public Person PostPersons(Person person)
        {
            _persons.Add(person);
          //  person.Id = _persons.Count;
            return person;

        }
    }
}