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

        // An API to get a category by id
        [HttpGet]
        [Route("api/categories/{id}")]
        public HttpResponseMessage GetCatById(int id)
        {
            var category = db.Categories.FirstOrDefault(cat => cat.Id == id);
            if (category == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.OK, category);
        }

        // Post API
        [HttpPost]
        [Route("api/categories")]
        public HttpResponseMessage PostCat(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "A new category added");
        }


        // An API to update the category data
        [HttpPut]
        [Route("api/categories/{id}")]
        public HttpResponseMessage PutCat(int id, Category category)
        {
            var catToUpdate = db.Categories.FirstOrDefault(cat => cat.Id == id);
            if (catToUpdate == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            catToUpdate.Name = category.Name;
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Category updated");
        }


        // An API to delete the category data by id
        [HttpDelete]
        [Route("api/categories/{id}")]
        public HttpResponseMessage DeleteCat(int id)
        {
            var catToDelete = db.Categories.FirstOrDefault(cat => cat.Id == id);
            if (catToDelete == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            db.Categories.Remove(catToDelete);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Category deleted");
        }


    }
}
