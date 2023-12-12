using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public int _score;
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
            ScoreText.text = "" + _score.ToString();
        }
    }

}

