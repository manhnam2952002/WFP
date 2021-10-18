using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFP.Model
{
     public class Contacts
    {
        public string Product { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        internal static void Add(Contacts contacts)
        {
            throw new NotImplementedException();
        }
    }

    public class Icons
    {
        public string IconPath { get; set; }
    }
}
