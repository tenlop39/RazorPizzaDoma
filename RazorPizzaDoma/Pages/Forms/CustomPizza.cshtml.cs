using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaDoma.Models; //ten to radek umozneje pristup do PizzasModel.cs
using System.Reflection.Metadata.Ecma335; //???

namespace RazorPizzaDoma.Pages.Forms
{
    //--------------------------------------------------TOHLE JE VIEW MODEL--------------------------------------//
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]

        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }
        //onPost method zachoti a pouzije vse co bylo submited with the post method (form in CustomPizza.cshtml has post method and submit btb
        //IActionResult je typ OnPost() metody, jako int, string...
        public IActionResult OnPost()
        {
            //if (Pizza.TomatoSauce) then PizzaPrice += 10;
            PizzaPrice = Pizza.BasePrice;    
            if (Pizza.TomatoSauce) PizzaPrice += 10;
            if (Pizza.Cheese) PizzaPrice += 10;
            if (Pizza.Peperoni) PizzaPrice += 10;
            if (Pizza.Mushroom) PizzaPrice += 10; 
            if (Pizza.Tuna) PizzaPrice += 10;
            if (Pizza.Pineapple) PizzaPrice += 50;
            if (Pizza.Ham) PizzaPrice += 10;
            if (Pizza.Beef) PizzaPrice += 10;
                                                     //novy objekt PizzaName, Pizzaprice 
            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});
        }
    }
}
