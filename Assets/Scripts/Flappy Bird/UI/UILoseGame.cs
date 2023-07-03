using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UILoseGame : MonoBehaviour
{
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI bestScoreText;
    public Image medalImage;

    public Sprite
        goldSprite,
        silverSprite,
        bronzeSprite;

    public List<GameObject> listButtons = new List<GameObject>();

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void SetPlayerScoreText(int score)
    {
        StartCoroutine(CountingScore(score, 2f));
    }

    private IEnumerator CountingScore(int target, float duration)
    {
        playerScoreText.text = 0.ToString();
        yield return new WaitForSeconds(1f);

        if (target != 0)
        {
            float yieldTime = duration / target;
            for (int i = 0; i <= target; i++)
            {
                playerScoreText.text = i.ToString();
                yield return new WaitForSeconds(yieldTime);
            }
        }

        for (int i = 0; i < listButtons.Count; i++)
        {
            listButtons[i].SetActive(true);
        }
    }

    public void SetBestScoreText(int bestScore)
    {
        bestScoreText.text = bestScore.ToString();
    }
    public void SetMedalImage(int score)
    {
        // Vang, Bac Dong
        // 7, 4, <
        if (score >= 7)
        {
            // Set to Gold
            Debug.Log("Player gain gold");
            medalImage.sprite = goldSprite;
        }
        else if (score >= 4) // 7 > score >= 4
        {
            // Set to Silver
            Debug.Log("Player gain silver");
            medalImage.sprite = silverSprite;
        }
        else
        {
            // Set to Bronze
            Debug.Log("Player gain bronze");
            medalImage.sprite = bronzeSprite;
        }
    }

    public void PlayAgainOnClicked()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
