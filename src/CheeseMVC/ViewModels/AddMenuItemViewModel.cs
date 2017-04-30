using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {

        [Display(Name = "Cheese")]
        public Menu Menu { get; set; }
        public List<SelectListItem> Cheeses { get; set; }
        
        
        public int CheeseID { get; set; }
        public int MenuID { get; set; }


        public AddMenuItemViewModel() { }

        public AddMenuItemViewModel(Menu aMenu, IEnumerable<Cheese> cheeses)
        {
            
            Cheeses = new List<SelectListItem>();

            foreach (var cheese in cheeses)
            {
                Cheeses.Add(new SelectListItem
                {
                    Value = cheese.ID.ToString(),
                    Text = cheese.Name
                });
            }
            Menu = aMenu;
        }

    }
}
