[System.Serializable]
public class Player : SaveableObject {
    public InventoryManager inventory = new InventoryManager();
    public Attributes attributes = new Attributes();
}