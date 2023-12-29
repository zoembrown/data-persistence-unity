using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class EndScreenUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI congratsText;
    [SerializeField] private TextMeshProUGUI currentScoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    public void Start()
    {
        Debug.Log("EndScreenUI.cs is running");
        congratsText.text = $"Congratulations {MainManager.Instance.currentPlayerName}";
        currentScoreText.text = $"Your score: {MainManager.Instance.currentScore}";
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
}
