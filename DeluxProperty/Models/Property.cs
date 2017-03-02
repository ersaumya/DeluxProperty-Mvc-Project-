using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeluxProperty.Models
{
    public class Property
    {
        public int PropertyId { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Detail")]
        [DataType(DataType.MultilineText)]
        public string Detail { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Price")]
        public string Price { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Area m\u00b2")]
        public string Area { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Room Number")]
        public string RoomNumber { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Floor Number")]
        public string FloorNumber { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Total Floor")]
        public string TotalFloor { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Heating System ")]
        public string HeatingSystem { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Building Age")]
        public string BuildingAge { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        public DateTime Date { get; set; }


        public virtual ICollection<PropertyImage> PropertyImages { get; set; }
        public IEnumerable<SelectListItem> RoomNumberLists
        {
            get
            {
                return new List<SelectListItem>
                {
                    new SelectListItem {Text="Please Select...",Value="" },
                    new SelectListItem {Text="1+0",Value="1+0"},
                     new SelectListItem {Text="1+1",Value="1+1"},
                      new SelectListItem {Text="2+1",Value="2+1"},
                       new SelectListItem {Text="2+2",Value="2+2"},
                        new SelectListItem {Text="3+1",Value="3+1"},
                         new SelectListItem {Text="3+2",Value="3+2"},
                          new SelectListItem {Text="4+1",Value="4+1"},
                           new SelectListItem {Text="4+2",Value="4+2"},
                            new SelectListItem {Text="4+3",Value="4+3"},
                              new SelectListItem {Text="4+4",Value="4+4"},
                  };
            }


        }
        public IEnumerable<SelectListItem> FloorNumberList
        {
            get
            {
                return new List<SelectListItem>
                {
                    new SelectListItem {Text="Please Select...",Value="" },
                    new SelectListItem {Text="Garden Floor",Value="Garden Floor"},
                     new SelectListItem {Text="Ground Floor",Value="Ground Floor"},
                    new SelectListItem {Text="Top Floor",Value="Top Floor"},
                     new SelectListItem {Text="1",Value="1"},
                     new SelectListItem {Text="2",Value="2"},
                      new SelectListItem {Text="3",Value="3"},
                      new SelectListItem {Text="4",Value="4"},
                      new SelectListItem {Text="5",Value="5"},
                      new SelectListItem {Text="6",Value="6"},
                       new SelectListItem {Text="7",Value="7"},
                    new SelectListItem {Text="8",Value="8"},
                    new SelectListItem {Text="9",Value="9"},
                    new SelectListItem {Text="10",Value="10"},
                    new SelectListItem {Text="10+",Value="10+"},
                  };
            }


        }
        public IEnumerable<SelectListItem> TotalFloorList
        {
            get
            {
                return new List<SelectListItem>
                {
                    new SelectListItem {Text="Please Select...",Value="" },
                   
                     new SelectListItem {Text="1",Value="1"},
                     new SelectListItem {Text="2",Value="2"},
                      new SelectListItem {Text="3",Value="3"},
                      new SelectListItem {Text="4",Value="4"},
                      new SelectListItem {Text="5",Value="5"},
                      new SelectListItem {Text="6",Value="6"},
                       new SelectListItem {Text="7",Value="7"},
                    new SelectListItem {Text="8",Value="8"},
                    new SelectListItem {Text="9",Value="9"},
                    new SelectListItem {Text="10",Value="10"},
                    new SelectListItem {Text="10+",Value="10+"},
                  };
            }


        }

        public IEnumerable<SelectListItem> HeatingSystemList
        {
            get
            {
                return new List<SelectListItem>
                {
                    new SelectListItem {Text="Please Select...",Value="" },
                    new SelectListItem {Text="None",Value="None"},
                     new SelectListItem {Text="Stove",Value="Stove"},
                      new SelectListItem {Text="Natural Gas",Value="Natural Gas"},
                     

                  };
            }


        }
    }
}