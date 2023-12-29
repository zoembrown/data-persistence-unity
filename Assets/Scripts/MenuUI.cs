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
    public TextMeshProUGUI playerName;

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
        SceneManager.LoadScene(1);
    }
}
