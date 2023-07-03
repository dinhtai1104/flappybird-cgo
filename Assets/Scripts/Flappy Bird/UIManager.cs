using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Những script sử dụng các component của UI thì sẽ cần using UnityEngine.UI
public class UIManager : MonoBehaviour
{
    public static UIManager Instance = null;

    public GameObject buttonStartGame;
    public TextMeshProUGUI textScore;

    public GameObject splashScreen;
    public UILoseGame loseGamePanel;

    // Start is called before the first frame update
    void Start()
    {
        splashScreen.SetActive(false);
        Instance = this;
        UpdateScore(0);
    }

    public void StartGameOnClicked()
    {
        GameManager.Instance.StartGame();
        buttonStartGame.SetActive(false);
    }
    
    public void PauseGame()
    {
        GameManager.Instance.PauseGame();
    }

    public void UpdateScore(int score)
    {
        textScore.text = score.ToString();
    }

    public void LoseGame()
    {
        StartCoroutine(WaitForLose());
    }

    private IEnumerator WaitForLose()
    {
        splashScreen.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        splashScreen.SetActive(false);

        yield return new WaitForSeconds(0.5f);
        loseGamePanel.Show();

        int playerScore = GameManager.Instance.GetScore();

        loseGamePanel.SetPlayerScoreText(playerScore);
        loseGamePanel.SetMedalImage(playerScore);

        int bestScore = PlayerPrefs.GetInt("BestScore");
        loseGamePanel.SetBestScoreText(bestScore);
    }
}
