using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int _score;
    public TextMeshProUGUI ScoreText;

    public int ScoreUI
    {
        get => _score;

        set
        {
            _score = value;
            ScoreText.text = "" + _score;
        }
    }
}

