using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Singleton
public class GameManager : MonoBehaviour // this = new GameManager();
{
    public static GameManager Instance = null;
    public bool isEndGame;
    public bool isStartGame;
    public int score;
    public bool isPauseGame;

    public BirdController bird;

    private int collisionCount = 0;
    private void Start()
    {
        Instance = this;
        isPauseGame = false;
        isStartGame = false;
    }

    public void StartGame()
    {
        isStartGame = true;
        bird.StartGame();
    }

    public void PauseGame()
    {
        if (isPauseGame == false)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    protected void Pause()
    {
        isPauseGame = true;
        Time.timeScale = 0;

        // Goi den AudioManager de tat nhac
    }

    protected void Resume()
    {
        isPauseGame = false;
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        if (collisionCount == 0)
        {
            isEndGame = true;
            AudioManager.Instance.PlayEndGameAudio();
            UIManager.Instance.LoseGame();
        }
        collisionCount++;
    }

    public void AddScore()
    {
        score++;
        UIManager.Instance.UpdateScore(score);
        AudioManager.Instance.PlayScoreAudio();
    }
}
