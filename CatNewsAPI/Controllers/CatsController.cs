using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CatNewsAPI;
using CatNewsAPI.Models;

namespace CatNewsAPI.Controllers
{
    public class CatsController : ApiController
    {
        CFDatabaseContext db = new CFDatabaseContext();

        [HttpGet]
        [Route("api/cats")]
        public HttpResponseMessage GetCats()
        {
            var allCatData = db.Cats.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, allCatData);
        }

        [HttpGet]
        [Route("api/cats/{id}")]
        public HttpResponseMessage GetCatsById(int id)
        {
            var selectedCat = db.Cats.Find(id);
            return Request.CreateResponse(HttpStatusCode.OK,selectedCat);
        }

        [HttpGet]
        [Route("api/cats/{title}")]
        public HttpResponseMessage GetCatsByTitle(string title)
        {
            return Request.CreateResponse(HttpStatusCode.OK, db.Cats.Find(title));

        }

        [HttpPost]
        [Route("api/cats")]
        public HttpResponseMessage PostCats(Cat cat)
        {
            db.Cats.Add(cat);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "A new cat details inserted");
        }
    }
}