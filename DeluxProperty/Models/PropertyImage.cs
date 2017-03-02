using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeluxProperty.Models
{
    public class PropertyImage
    {
        public int PropertyImageId { get; set; }
        public Guid Guid { get; set; }
        public string ImageName { get; set; }
        public string Extenstion { get; set; }
        public int PropertyId { get; set; }
        public virtual Property  Property{ get; set; }
    }
}