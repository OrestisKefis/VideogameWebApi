using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeirdStreamer.Controllers
{
    public class VideoGameController : Controller
    {
        // GET: VideoGame
        public ActionResult Index()
        {
            return View();
        }
    }
}