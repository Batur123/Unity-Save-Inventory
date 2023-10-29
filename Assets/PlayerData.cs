using UnityEngine;

public class PlayerData : MonoBehaviour {
    public Player player = new Player();

    private void Update() {
        // X Save Game
        if (Input.GetKey(KeyCode.X)) {
            player.attributes.SetCharacterLocation(transform);
            player.Save("playerDat");
        }

        // C Load Game
        if (Input.GetKey(KeyCode.C)) {
            player = player.Load<Player>("playerDat");
            
            Vector3 savedPosition = new Vector3(
                player.attributes.CharacterLocation[0],
                player.attributes.CharacterLocation[1],
                player.attributes.CharacterLocation[2]
            );

            transform.position = savedPosition;
        }
        
        // V Gives Starter Items
        if (Input.GetKey(KeyCode.V)) {
            StarterItems.GiveStarterItems(player);
        }
    }
}



