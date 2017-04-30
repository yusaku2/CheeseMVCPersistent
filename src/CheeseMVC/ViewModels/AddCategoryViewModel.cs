using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CheeseMVC.ViewModels
{
    public class AddCategoryViewModel
    {

        [Required(ErrorMessage="Give your category a name, fool!")]
        [Display(Name="Category Name")]
        public string Name { get; set; }
        public int ID { get; set; }
    
    }
}
