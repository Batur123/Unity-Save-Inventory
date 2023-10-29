using UnityEngine;

public abstract class SaveableObject {
    private string GetJson() {
        return JsonUtility.ToJson(this);
    }

    public void Save(string saveName) {
        string data = this.GetJson();
        string filePath = $"{Application.persistentDataPath}/{saveName}.json";
        Debug.Log($"{this.GetType().Name} has been saved -> {filePath}");
        System.IO.File.WriteAllText(filePath, data);
    }

    public T Load<T>(string saveName) {
        string filePath = $"{Application.persistentDataPath}/{saveName}.json";
        Debug.Log($"{this.GetType().Name} is loaded -> {filePath}");
        string playerData = System.IO.File.ReadAllText(filePath);
        Debug.Log($"{playerData}");
        return JsonUtility.FromJson<T>(playerData);
    }
}
