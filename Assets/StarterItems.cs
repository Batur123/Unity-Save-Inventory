using UnityEngine;

public class StarterItems {
    public static void GiveStarterItems(Player player) {
        if (player.attributes.IsAcquiredStaterItems) {
            Debug.Log("Player already got started items.");
            return;
        }

        // Create and add starter items to the player's inventory using the InventoryManager.
        Item healthPotion = new Item("1", "Health Potion"
            , "This potion heals you"
            , ItemTypes.Consumable, 5);
        healthPotion.AddEffect(EffectTypes.Health, 50);

        Item woodenSword = new Item("2", "Wooden Sword"
            , "It looks like training sword. Weak and ready to break"
            , ItemTypes.Weapon, 1);
        woodenSword.AddEffect(EffectTypes.Damage, 10);

        Item ironShield =
            new Item("3", "Iron Shield", "Strong cast iron armor"
                , ItemTypes.Armor, 1);
        ironShield.AddEffect(EffectTypes.Armor, 20);

        // Add the starter items to the player's inventory using the InventoryManager.
        player.inventory.AddItem(healthPotion);
        player.inventory.AddItem(woodenSword);
        player.inventory.AddItem(ironShield);
        player.attributes.IsAcquiredStaterItems = true;
    }
}
