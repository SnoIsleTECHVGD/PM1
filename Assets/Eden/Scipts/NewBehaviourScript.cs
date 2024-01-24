using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("level");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits1");
    }
    public void Title()
    {
        SceneManager.LoadScene("Main Title");
    }
}
