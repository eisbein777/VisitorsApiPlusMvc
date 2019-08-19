using FitzroyVisitors.Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;

namespace FitzroyVisitors.Controllers
{
    public class DisplayVisitorController : Controller
    {
        private IFitzroyBusSvc _fitzroyBusSvc;

        public DisplayVisitorController(IFitzroyBusSvc fitzroyBusSvc)
        {
            _fitzroyBusSvc = fitzroyBusSvc;
        }


        // GET: DisplayVisitor
        public ActionResult Index()
        {
          


            var visitors  = _fitzroyBusSvc.GetVisitors();
            //var vis = visitors.Take(1).FirstOrDefault();

            //using (var ms = new MemoryStream(vis.Signature))
            //{
            //  var img = Image.FromStream(ms);
            //    img.Save(@"C:\Temp\zz.png");
            //}


            //string imreBase64Data = Convert.ToBase64String(vis.Signature);
            //string imgDataURL = string.Format("data:image/png;base64,{0}", imreBase64Data);
            //ViewBag.ImageData = imgDataURL;

            return View(visitors);
        }
    }
}