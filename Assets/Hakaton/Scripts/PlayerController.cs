using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int lives = 10;
    public Text livesText;
    
    void Start()
    {
        if (livesText == null)
        {
            Debug.LogError("Assign Text object to Lives Text in the Inspector!");
        }

        UpdateUI();
    }
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("miay");
        if (collision.CompareTag("Snowman"))
        {
            
            lives--;

            if (lives <= 0)
            {
                
                GameOver();
            }
            else
            {
                
                UpdateUI();
            }
        }
    }

    void UpdateUI()
    {
        
        if (livesText != null)
        {
            livesText.text = "Жизни: " + lives.ToString();
        }
    }

    void GameOver()
    {
       
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}

