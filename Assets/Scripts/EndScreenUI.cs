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
        if (MainManager.Instance.currentScore >= MainManager.Instance.highScore)
        {
            MainManager.Instance.highScore = MainManager.Instance.currentScore;
            MainManager.Instance.highScoringPlayerName = MainManager.Instance.currentPlayerName;
            MainManager.Instance.SaveData();
        }

        congratsText.text = $"Congratulations {MainManager.Instance.currentPlayerName}";
        currentScoreText.text = $"Your score: {MainManager.Instance.currentScore}";
        highScoreText.text = $"High Score\n{MainManager.Instance.highScoringPlayerName}: {MainManager.Instance.highScore}";
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
