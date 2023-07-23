using CatNewsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CatNewsAPI.Controllers
{
    public class CategoryController : ApiController
    {
        CFDatabaseContext db = new CFDatabaseContext();

        [HttpGet]
        [Route("api/categories")]
        public HttpResponseMessage GetCat()
        {
            var allCatData = db.Categories.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, allCatData);
        }

        [HttpPost]
        [Route("api/categories")]
        public HttpResponseMessage PostCat(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "A new category added");
        }
    }
}
