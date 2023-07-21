﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
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
        public HttpResponseMessage GetCats(int id)
        {
            var selectedCat = db.Cats.Find(id);
            if (selectedCat == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Cat not found");
            }
            return Request.CreateResponse(HttpStatusCode.OK,selectedCat);
        }

        [HttpGet]
        [Route("api/cats/title/{title}")]
        public HttpResponseMessage GetCats(string title)
        {
            //var selectedCat = db.Cats.Where(cat => cat.Title == title).ToList();
            try
            {
               // var selectedCat = db.Cats
                 //   .Where(cat => cat.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0)
               //     .ToList();
                var selectedCat = db.Cats
                .Where(cat => SqlFunctions.PatIndex("%" + title + "%", cat.Title) > 0)
                .ToList();

                return Request.CreateResponse(HttpStatusCode.OK, selectedCat);
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately, e.g., log the error and return an error response.
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "An error occurred while fetching cats."+ ex);
            }
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