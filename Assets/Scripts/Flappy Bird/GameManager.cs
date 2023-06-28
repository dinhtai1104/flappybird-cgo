using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Singleton
public class GameManager : MonoBehaviour // this = new GameManager();
{
    public static GameManager Instance = null;
    public bool isEndGame;
    public int score;

    private int collisionCount = 0;
    private void Start()
    {
        Instance = this;
    }

    public void EndGame()
    {
        if (collisionCount == 0)
        {
            isEndGame = true;
            AudioManager.Instance.PlayEndGameAudio();
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
