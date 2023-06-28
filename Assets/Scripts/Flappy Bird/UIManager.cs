using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Những script sử dụng các component của UI thì sẽ cần using UnityEngine.UI
public class UIManager : MonoBehaviour
{
    public static UIManager Instance = null;

    public Text textScore;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }
    
    public void UpdateScore(int score)
    {
        textScore.text = score.ToString();
    }
}
