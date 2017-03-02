using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeluxProperty.DB;
using DeluxProperty.Models;
using System.IO;

namespace DeluxProperty.Controllers
{

    public class AdminController : Controller
    {
        private StarDBContext db = new StarDBContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PropertyList()
        {
            return View(db.Properties.ToList());
        }
        public ActionResult AddProperty()
        {
            return View(new Property());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProperty([Bind(Include = "PropertyId,Title,Detail,Price,Area,RoomNumber,FloorNumber,TotalFloor,HeatingSystem,BuildingAge,Country,City, State, Address")]Property property)
        {
            if(ModelState.IsValid)
            {
                List<PropertyImage> propertyImageList = new List<PropertyImage>();
                for(int i=0;i<Request.Files.Count;i++)
                {
                    var file = Request.Files[i];
                    if(file != null && file.ContentLength>0)
                    {
                        var filename = Path.GetFileName(file.FileName);
                        PropertyImage propertyImage = new PropertyImage()
                        {
                            ImageName = filename,
                            Extenstion = Path.GetExtension(filename),
                            Guid = Guid.NewGuid()

                        };
                        propertyImageList.Add(propertyImage);
                        var path = Path.Combine(Server.MapPath("~/Images/Property"), propertyImage.Guid + propertyImage.Extenstion);
                        file.SaveAs(path);

                    }

                }
                property.PropertyImages = propertyImageList;
                property.Date = DateTime.Now;
                db.Properties.Add(property);
                db.SaveChanges();
                TempData["message"] = string.Format("Property added successfully");
                return RedirectToAction("PropertyList");
            }
            return View();
        }
    }
}