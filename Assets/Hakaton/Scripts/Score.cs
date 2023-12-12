using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    private int _score;
    public Text ScoreText;

    public int ScoreUI
    {
        get => _score;

        set
        {
            _score += value;
            UpdateScoreUI();
        }
    }
    private void UpdateScoreUI()
    {
        if (ScoreText != null)
        {
            ScoreText.text = "Score: " + _score.ToString();
        }
    }

}

