using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestApplication.Api.Models;

namespace RestApplication.Api.Controllers
{
    public class ContactController : ApiController
    {
        // GET api/values
        public ContactViewModel[] Get()
        {
            return new ContactViewModel[]
            {
                 new ContactViewModel()
                    {
                        Id = 1,
                        Name = "Glenn Block"
                    },
                new ContactViewModel()
                    {
                        Id = 2,
                        Name = "Dan Roth"
                    }
            };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}