using System.Collections.Generic;

[System.Serializable]
public class InventoryManager: SaveableObject {
    public List<Item> items = new List<Item>();
    
    public void AddItem(Item item)
    {
        items.Add(item);
    }
}
