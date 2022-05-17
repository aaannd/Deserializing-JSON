using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDeserializingJSON
{
     class jsonPersonArray
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public double age { get; set; }
        public bool isAlive { get; set; }
        public addr address { get; set; }
        public phoneNum phoneNumbers { get; set; }

        public class addr
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public double postcode { get; set; }

            public class phoneNum
            {
                public string type { get; set; }
                public string number { get; set; }
                //public double postcode { get; set; }
            }
        }
    }
}
