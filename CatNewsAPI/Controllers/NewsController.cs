using System;
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
    public class NewsController : ApiController
    {
        CFDatabaseContext db = new CFDatabaseContext();

        [HttpGet]
        [Route("api/news")]
        public HttpResponseMessage GetNews()
        {
            var allNewsData = db.News.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, allNewsData);
        }

        [HttpGet]
        [Route("api/news/{id}")]
        public HttpResponseMessage GetNews(int id)
        {
            var selectedCat = db.News.Find(id);
            if (selectedCat == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "News not found");
            }
            return Request.CreateResponse(HttpStatusCode.OK,selectedCat);
        }

        [HttpGet]
        [Route("api/news/title/{title}")]
        public HttpResponseMessage GetNews(string title)
        {
            //var selectedCat = db.Cats.Where(cat => cat.Title == title).ToList();
            try
            {
               // var selectedCat = db.Cats
                 //   .Where(cat => cat.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0)
               //     .ToList();
                var selectedCat = db.News
                .Where(cat => SqlFunctions.PatIndex("%" + title + "%", cat.Title) > 0)
                .ToList();

                return Request.CreateResponse(HttpStatusCode.OK, selectedCat);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "An error occurred while fetching news."+ ex);
            }
        }


        [HttpPost]
        [Route("api/news")]
        public HttpResponseMessage PostNews(News news)
        {
            db.News.Add(news);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "A new News posted");
        }
    }
}