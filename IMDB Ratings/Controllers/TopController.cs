﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IMDB_Ratings.Models;

namespace IMDB_Ratings.Controllers
{
    public class TopController : Controller
    {
        private DB_128040_practiceEntities db = new DB_128040_practiceEntities();

        // GET: Top
        public ActionResult Movies(int number =10)
        {
            var movies = db.Movies.Include(m => m.Director).OrderByDescending(m=>m.gross).Take(number);
            return View(movies.ToList());
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
