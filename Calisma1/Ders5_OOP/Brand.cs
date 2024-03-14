using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders5_OOP
{
    public class Brand // Model
    {
        public int brandID  {get; set;}
        public string brandName  {get; set;}

        public Brand(int brandID, string brandName)
        {
            this.brandID = brandID;
            this.brandName = brandName;
        }

    }
}
