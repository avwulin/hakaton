using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadThisScene : MonoBehaviour
{
    public string SceneName;
    public void Load()
    {
        SceneManager.LoadScene(SceneName);
    }
    public void Close()
    {
        Application.Quit();
    }
}
