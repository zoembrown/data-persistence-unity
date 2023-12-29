using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
        DontDestroyOnLoad(gameObject);
    }

    // A class containing the data that needs to be saved
    [System.Serializable]
    class HighScore
    {
        public int score;
        public string player;
    }

    // A method to save the data in json format
    // A method to load the data from the file
}
