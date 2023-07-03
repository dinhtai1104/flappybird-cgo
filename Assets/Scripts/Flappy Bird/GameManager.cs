using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Singleton
public class GameManager : MonoBehaviour // this = new GameManager();
{
    public static GameManager Instance = null;
    public bool isEndGame;
    public bool isStartGame;
    public bool isPauseGame;
    public float speed;

    public Transform spawnPosition;
    public BirdController birdPrefab;
    public BirdController bird;

    private int collisionCount = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        isPauseGame = false;
        isStartGame = false;

        bird = Instantiate(birdPrefab, spawnPosition.position, Quaternion.identity);
        bird.rb.gravityScale = 0;
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
            bird.Dead();
            DataManager.Instance.SetBestScore();
            isEndGame = true;
            AudioManager.Instance.PlayEndGameAudio();
            UIManager.Instance.LoseGame();
        }
        collisionCount++;
    }

    public void AddScore()
    {
        DataManager.Instance.AddScore();
        int playerScore = DataManager.Instance.GetScore();
        UIManager.Instance.UpdateScore(playerScore);
        AudioManager.Instance.PlayScoreAudio();
    }

    public int GetScore()
    {
        return DataManager.Instance.GetScore();
    }
}
