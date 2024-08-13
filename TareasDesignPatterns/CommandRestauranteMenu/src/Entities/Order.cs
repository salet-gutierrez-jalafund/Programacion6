namespace CommandRestauranteMenu.src.Entities;

public class Order
{
    public List<MenuItem> Items { get; private set; } = new List<MenuItem>();

    public void AddItem(MenuItem item)
    {
        Items.Add(item);
    }

    public decimal GetTotal()
    {
        return Items.Sum(i => i.Price);
    }
}
