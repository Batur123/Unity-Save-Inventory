using System.Collections.Generic;

public enum ResistanceTypes {
    Fire,
    Cold,
    Poison,
    Acid,
    Toxic,
    Magic,
    None,
}

public enum EffectTypes {
    Damage,
    Health,
    Armor,
    StatusResistance,
}

public enum ItemTypes {
    Weapon,
    Armor,
    Consumable,
}

[System.Serializable]
public struct Effect {
    public EffectTypes effectType;
    public int value;
    public ResistanceTypes statusResistanceType;

    public Effect(EffectTypes type, int val) {
        effectType = type;
        value = val;
        statusResistanceType = ResistanceTypes.None;
    }

    public Effect(EffectTypes type, int val, ResistanceTypes resistanceType) {
        effectType = type;
        value = val;
        statusResistanceType = resistanceType;
    }
}

[System.Serializable]
public class Item : SaveableObject {
    public ItemTypes itemType;
    public string itemId;
    public string itemName;
    public string itemDescription;
    public bool isStackable;
    public bool isEquipable;
    public bool isConsumable;
    public int amount;
    public List<Effect> effects;
    
    public Item(string itemId, string itemName, string itemDescription, ItemTypes itemType, int amount)
    {
        this.itemId = itemId;
        this.itemName = itemName;
        this.itemDescription = itemDescription;
        this.itemType = itemType;
        this.amount = amount;
        effects = new List<Effect>();
    }

    public void AddEffect(EffectTypes effectType, int value, ResistanceTypes statusResistanceType = ResistanceTypes.None)
    {
        Effect newEffect = new Effect
        {
            effectType = effectType,
            value = value,
            statusResistanceType = statusResistanceType,
        };
        effects.Add(newEffect);
    }
}