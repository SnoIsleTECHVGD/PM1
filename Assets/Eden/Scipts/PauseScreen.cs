using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{

    public void Quit()
    {
        Application.Quit();
    }

    public void freeze(float scale)
    {
        Time.timeScale = scale;
    }
    public void ByeByeScreen()
    {
        SceneManager.UnloadSceneAsync("Main Pause");
    }

}
