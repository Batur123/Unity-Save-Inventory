using UnityEngine;

[System.Serializable]
public class Attributes : SaveableObject {
    [SerializeField] private int health;
    [SerializeField] private int armor;
    [SerializeField] private int level;
    [SerializeField] private float[] characterLocation;
    [SerializeField] private int maxInventorySize = 20;
    [SerializeField] private bool isAcquiredStaterItems = false;

    public void SetCharacterLocation(Transform transform) {
        if (characterLocation == null || characterLocation.Length != 3) {
            characterLocation = new float[3];
        }
        
        characterLocation[0] = transform.position.x;
        characterLocation[1] = transform.position.y;
        characterLocation[2] = transform.position.z;
    }

    public bool IsAcquiredStaterItems {
        get { return isAcquiredStaterItems; }
        set { isAcquiredStaterItems = value; }
    }
    
    public int Health {
        get { return health; }
        set { health = Mathf.Clamp(value, 0, 100); }
    }

    public int Armor {
        get { return armor; }
        set { armor = value; }
    }

    public int Level {
        get { return level; }
        set { level = value; }
    }

    public float[] CharacterLocation {
        get { return characterLocation; }
        set { characterLocation = value; }
    }
}