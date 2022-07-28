using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string Name;
    public string MaxName;
    public int MaxScore;

    private void Awake()
    {
        // start if new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadName();
    }

    [System.Serializable]
    class SaveData
    {
        public string Name;
        public string MaxName;
        public int MaxScore;
    }

    public void SaveName()
    {
        SaveData data = new SaveData();
        data.Name = Name;
        data.MaxName = MaxName;
        data.MaxScore = MaxScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadName()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            Name = data.Name;
            MaxName = data.MaxName;
            MaxScore = data.MaxScore;
        }
    }
}
