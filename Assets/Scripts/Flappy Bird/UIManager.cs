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

    public GameObject loseGamePanel;
    // Start is called before the first frame update
    void Start()
    {
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
        loseGamePanel.SetActive(true);
    }
}
