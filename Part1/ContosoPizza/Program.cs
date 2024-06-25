// See https://aka.ms/new-console-template for more information
using ContosoPizza.Data;
using ContosoPizza.Models;

using ContosoPizzaContext context = new ContosoPizzaContext();

Product veggieSpecial = new Product()
{
    Name = "Veggie Special Pizza",
    Price = 9.99M
};
Console.WriteLine("Going to Add the Product : " + veggieSpecial.Name);
context.Products.Add(veggieSpecial);
Console.WriteLine("Wow! Our Product " + veggieSpecial.Name + " is Added Successfully!");

Product deluxeMeat = new Product()
{
    Name = "Deluxe Meat Pizza",
    Price = 12.99M
};
Console.WriteLine("Going to Add the Product : " + deluxeMeat.Name);
context.Add(deluxeMeat);
Console.WriteLine("Wow! Our Product " + deluxeMeat.Name + " is Added Successfully!");
context.SaveChanges();
