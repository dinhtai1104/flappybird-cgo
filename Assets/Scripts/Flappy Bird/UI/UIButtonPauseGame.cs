using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonPauseGame : MonoBehaviour
{
    public Image imageButton;
    public Sprite buttonPauseSprite;
    public Sprite buttonResumeSprite;

    private void Start()
    {
        imageButton.sprite = buttonPauseSprite;
    }

    public void PauseGameOnClicked()
    {
        // Goi ??
        UIManager.Instance.PauseGame(); // GameMAnager.isPause = true|false
        ChangeButtonImage();
    }

    private void ChangeButtonImage()
    {
        if (GameManager.Instance.isPauseGame)
        {
            imageButton.sprite = buttonResumeSprite;
        }
        else
        {
            imageButton.sprite = buttonPauseSprite;
        }
    }
}
