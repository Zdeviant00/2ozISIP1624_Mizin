public enum ItemCategory
{
    Domestic,
    Childhood,
    Food
}
public class Item
{
    public int Id;
    public string Name;
    public decimal Price;
    public int Quantity;
    public bool Warehouse;
    public ItemCategory Category;

}

// Методы должны работать со списком (снаружи класса)