//--------------------------------------------------TOHLE JE VIEW MODEL--------------------------------------//
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzaDoma.Pages.Checkout
{
    [BindProperties(SupportsGet = true)] //co to je binding, SupportsGet?
                                         //plati pro vsechno v classe níže// nevim jak se liso od [BindProperty] v CustomPizza.cshtml.cs
                                         //SupportsGet je aby mohl prijimat informace z checkout stranky
    public class CheckoutModel : PageModel
    {
        //stejne nazvy propertie?, zelene podtrzeno?
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            //predpokladam: if string PizzaName = nic nenapsano nebo mezernik, tak then do. asi kdyz neni definovano ani jedno z properties výsledek da do pizza name castum a image Create

            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle= "Create";
            }

        }
    }
}
