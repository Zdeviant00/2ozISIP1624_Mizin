using System;
List<Item> items = new List<Item>();
items.Add(new Item(Id.g, "Pineapple", 350, 24, ItemCategory.Food));
Id.addd();//  Нужно будет перенести в void AddItem
items.Add(new Item(Id.g, "Soap", 75, 120, ItemCategory.Domestic));
Id.addd(); //  Нужно будет перенести в void AddItem
items.Add(new Item(Id.g, "MonsterTruck", 500, 0, ItemCategory.Toys));
Id.addd(); //  Нужно будет перенести в void AddItem
items.Add(new Item(Id.g, "TeddyBear", 200, 15, ItemCategory.Toys));
Id.addd(); //  Нужно будет перенести в void AddItem
items.Add(new Item(Id.g, "Bread", 50, 29, ItemCategory.Food));


void AddItem() 
{

}

void DeleteItem()
{

}

void OrderItem()
{

}

void SellItem()
{
    Console.WriteLine();
}

public enum ItemCategory
{
    Domestic,
    Toys,
    Food
}
static class Id
{
    public static int g = 0000001;
    public static void addd()
    {
        g++;
    }
}
public class Item
{
    public int Id;
    public string Name;
    public decimal Price;
    public int Quantity;
    public bool InStock;
    public ItemCategory Category;

    public Item(int Id, string Name, decimal Price, int Quantity, ItemCategory Category)
    {
        this.Id = Id;
        this.Name = Name;
        this.Price = Price;
        this.Quantity = Quantity;
        if (Quantity > 0 )
        {
            this.InStock = true;
        }
        else
        {
            this.InStock = false;
        }
            this.Category = Category;
    }
    }





