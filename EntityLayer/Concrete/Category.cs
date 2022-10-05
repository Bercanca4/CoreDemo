using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        //Category için 
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        //   List ve ICollection Farkı :  ICollection bir interface iken List bir Class'dır. List, ICollection ve birçok interface özelliğini kendine miras alabilir.

        public List<Blog> Blogs { get; set; }


    }
}
 