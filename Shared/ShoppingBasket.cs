﻿namespace PizzaPlace.Shared
{
    public class ShoppingBasket
    {
        public Customer Customer { get; set; } = new();
        public List<int> Orders { get; set; } = new();
        public bool HasPaid { get; set; }
        public void Add(int pizzaId) => Orders.Add(pizzaId);
        public void RemoveAt(int pizzaId) => Orders.Remove(pizzaId);
    }
}
