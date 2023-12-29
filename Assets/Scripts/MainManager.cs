using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public string currentPlayerName;
    public int currentScore;

    public string highScoringPlayerName;
    public int highScore;

    private string saveFile = "/savefile.json";

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;
        LoadData();
        DontDestroyOnLoad(gameObject);
    }

    // A class containing the data that needs to be saved
    [System.Serializable]
    class Data
    {
        public int score;
        public string player;
    }

    // A method to save the data in json format
    public void SaveData()
    {
        Data data = new Data();
        data.score = highScore;
        data.player = highScoringPlayerName;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText($"{Application.persistentDataPath}{saveFile}", json);
    }

    // A method to load the data from the file
    // If the file does not exist,
    public void LoadData()
    {

        string path = $"{Application.persistentDataPath}{saveFile}";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Data data = JsonUtility.FromJson<Data>(json);

            highScore = data.score;
            highScoringPlayerName = data.player;
        }
        else
        {
            highScore = -1;
        }
    }
}
