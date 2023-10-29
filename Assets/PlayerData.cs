using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public Player player = new Player();

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.Save();
        }

        if (Input.GetKey(KeyCode.A))
        {
            player = player.Load<Player>();
        }
    }
}

[System.Serializable]
public class Player : SaveableObject
{
    public Inventory inventory = new Inventory();
    public Attributes attributes = new Attributes();
}

[System.Serializable]
public class Inventory : SaveableObject
{
    public List<Item> items = new List<Item>();
}

[System.Serializable]
public class Item : SaveableObject
{
    public string itemId;
    public string itemName;
    public string itemDescription;
    public bool isStackable;
    public bool isEquipable;
    public bool isConsumable;
    public int amount;
}

[System.Serializable]
public class Attributes : SaveableObject
{
    public int health;
    public int armor;
    public int level;
    public float[] characterLocation;
    public int maxInventorySize = 20;
}

