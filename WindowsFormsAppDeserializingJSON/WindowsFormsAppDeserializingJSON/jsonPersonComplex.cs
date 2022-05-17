using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * {
    "firstname":"Andaru",
    "lastname" :"Nugroho",
    "age"      : 22,
    "isAlive"  :false,
    "address"  :
  { 
    "streetAddress" : "Warung Buncit Raya",
    "city"          : "Jakarta Selatan",
    "postcode"      : "12740"     
  },
    "phoneNumbers"  :
  [
    {"type" : "home", "number" :"0285 4494042"},
    {"type" : "mobile", "number" : "+6285 8760 32534"}
  ]

}

*/

namespace WindowsFormsAppDeserializingJSON
{
    class jsonPersonComplex
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public double age { get; set; }
        public bool isAlive { get; set; }
        public addr address { get; set; }

        public class addr
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public double postcode { get; set; }

            public class phoneNumbers
            {
                public string streetAddress { get; set; }
                public string city { get; set; }
                public double postcode { get; set; }
            }
        }
    }
}
