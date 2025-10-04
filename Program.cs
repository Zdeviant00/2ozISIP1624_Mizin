using System;
using System.Linq.Expressions;
using System.Reflection.Metadata;
// Наличие товара определяется в конструкторе
List<Item> items = new List<Item>();
items.Add(new Item(Id.g, "Pineapple", 350, 24, ItemCategory.Еда));
Id.addd();//  Нужно будет перенести в void AddItem
items.Add(new Item(Id.g, "Soap", 75, 120, ItemCategory.Хозтовары));
Id.addd(); //  Нужно будет перенести в void AddItem
items.Add(new Item(Id.g, "MonsterTruck", 500, 0, ItemCategory.Игрушки));
Id.addd(); //  Нужно будет перенести в void AddItem
items.Add(new Item(Id.g, "TeddyBear", 200, 15, ItemCategory.Игрушки));
Id.addd(); //  Нужно будет перенести в void AddItem
items.Add(new Item(Id.g, "Bread", 50, 29, ItemCategory.Еда));
int x;
do
{
    Console.WriteLine("\n 0.Выход из меню \n 1.Добавить товар \n 2.Удалить товар \n 3.Заказать поставку товара \n 4.Продать товар \n 5.Поиск товаров \n Выберите действие с помощью соответствубщей цифры меню");

    x = Convert.ToInt32(Console.ReadLine());

    switch (x)
    {
        case 1:
            AddItem();
            break;
            case 2:
            DeleteItem();
            break;
            case 3:
            OrderItem();
            break;
            case 4:
            SellItem(); 
            break;
            case 5:
            SearchItem();
            break;
            }

}
while (x != 0);



void AddItem() 
{
    // Наличие товара определяется в конструкторе
    string Name;
    decimal Price;
    int Quantity, NumberCat;
    ItemCategory Category;
    Console.WriteLine("Введите имя товара");
    Name = Console.ReadLine();
    Console.WriteLine("Введите цену товара");
    Price = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Введите количество товара");
    Quantity = Convert.ToInt32(Console.ReadLine());
    do {
        Console.WriteLine("Введите категорию товара с помощью выбора соответствующей цифры: \n Хозтовары: 1, \n Игрушки: 2 \n Еда: 3");
        NumberCat = Convert.ToInt32(Console.ReadLine());

        if (NumberCat < 1 || NumberCat > 3)
            Console.WriteLine("Выбрана несуществующая категория");
    }
    while (NumberCat < 0 && NumberCat > 4);
    Category = (ItemCategory)NumberCat;
    Id.addd();
    items.Add(new Item(Id.g, Name, Price, Quantity, Category));
    Console.WriteLine("Товар добавлен")
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

void SearchItem()
{
    Console.WriteLine();
}

public enum ItemCategory
{
    Хозтовары = 1,
    Игрушки,
    Еда
}
static class Id
{
    public static int g = 1000001;
    public static void addd(  )
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
        if (Quantity > 0) // Наличие товара определяется здесь
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





