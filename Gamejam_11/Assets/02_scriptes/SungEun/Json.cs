using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class allData
{
    public int bestScore = 0;
    public bool sound = true;
    public bool soundEffect = true;
    public bool vibration = true;
}

public class Json : MonoBehaviour
{
    public static Json Instance;

    string path;
    public allData gameData = new allData();

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        path = Application.dataPath + "/09_Data";

        if (Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        if (File.Exists(path + "gameData.txt"))
        {
            Load();
        }
        else
        {
            Save();
        }
    }

    public void Save()
    {
        string data = JsonUtility.ToJson(gameData);
        File.WriteAllText(path + "gameData.txt", data);
    }

    public void Load()
    {
        string data = File.ReadAllText(path + "gameData.txt");
        JsonUtility.FromJson<allData>(data);
    }
}
