using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * 
 * 
 * 
 * 
 * {
    "firstname":"Andaru",
    "lastname" :"Nugroho",
    "age"      :22,
    "isAlive"  :false
}
*/

namespace WindowsFormsAppDeserializingJSON
{
    class jsonPersonSimple
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public double age { get; set; }
        public bool isAlive { get; set; }


    }
}
