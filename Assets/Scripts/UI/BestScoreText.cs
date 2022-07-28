using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreText : MonoBehaviour
{
    private Text _bestScore;
    // Start is called before the first frame update
    void Start()
    {
        _bestScore = GetComponent<Text>();
        UpdateText();
    }

    public void UpdateText()
    {
        _bestScore.text = "Best Score: " + DataManager.Instance.MaxName + " : " + DataManager.Instance.MaxScore;
    }
}
