using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_ : MonoBehaviour
{   public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActive().buildIndex + 1);
    }
    public void ExitGame()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }
}
