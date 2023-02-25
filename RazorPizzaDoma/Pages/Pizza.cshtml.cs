using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaDoma.Models;//musi byt pridano aby mohl pouzivat PizzasModel

namespace RazorPizzaDoma.Pages
{
    public class PizzaModel : PageModel
    {
        //list of PizzasModel co se jmenuje fakePizzaDB
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>() //List<PizzasModel> je typ promenne fakePizzaDB?
        {
            new PizzasModel() {ImageTitle="Margerita", PizzaName="Margerita", BasePrice=90, TomatoSauce=true, Cheese=true, FinalPrice=110},
            new PizzasModel() {ImageTitle="Bolognese", PizzaName="Bolognese", BasePrice=90, TomatoSauce= true, Cheese=true, Beef=true, FinalPrice=120},
            new PizzasModel() {ImageTitle="Hawaiian", PizzaName="Hawaiian", BasePrice=90, TomatoSauce=true, Cheese=true, Ham=true, Peperoni=true, FinalPrice=170},
            new PizzasModel() {ImageTitle="Carbonara", PizzaName="Carbonara", BasePrice=90, TomatoSauce=true, Cheese=true, Ham=true, Mushroom=true, FinalPrice=130},
            new PizzasModel() {ImageTitle="MeatFeast", PizzaName="MeatFest", BasePrice=90, TomatoSauce=true, Cheese=true, Ham=true, Beef=true, FinalPrice=130},
            new PizzasModel() {ImageTitle="Mushroom", PizzaName="Mushroom", BasePrice=90, TomatoSauce=true, Cheese=true, Mushroom=true, FinalPrice=120},
            new PizzasModel() {ImageTitle="Pepperoni", PizzaName="Pepperoni", BasePrice=90, TomatoSauce=true, Cheese=true, Peperoni=true, FinalPrice=120},
            new PizzasModel() {ImageTitle="Seafood", PizzaName="Seafood", BasePrice=90, TomatoSauce=true, Cheese=true, Tuna=true, FinalPrice=120},
            new PizzasModel() {ImageTitle="Vegetarian", PizzaName="Vegetarian", BasePrice=90, TomatoSauce=true, Cheese=true, Mushroom=true, Peperoni=true, FinalPrice=130},


        };
        public void OnGet()
        {
        }
    }
}
