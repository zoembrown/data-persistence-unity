using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
    [SerializeField] private TMP_InputField playerName;
    [SerializeField] private TextMeshProUGUI errorText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    public void Start()
    {
        highScoreText.text = $"High Score\n{MainManager.Instance.highScoringPlayerName}: {MainManager.Instance.highScore}";
    }
    // A method to close the program
    public void CloseGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    // A method to start the game
    public void StartGame()
    {
        // Do not start the game until the user has enetered their name.
        string name = playerName.text.Trim();

        if (name.Equals(""))
        {
            errorText.gameObject.SetActive(true);
        } else
        {
            //MainManager.Instance.currentPlayerName = name;
            MainManager.Instance.currentPlayerName = name;
            SceneManager.LoadScene(1);
        }
        
    }
}
