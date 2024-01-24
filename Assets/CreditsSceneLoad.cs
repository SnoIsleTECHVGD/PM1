using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CreditsSceneLoad : MonoBehaviour
{
    public void Credits1()
    {
        SceneManager.LoadScene("Credits2");
    }

    public void Credits2()
    {
        SceneManager.LoadScene("Credits3");
    }

    public void Credits3()
    {
        SceneManager.LoadScene("Credits4");
    }

    public void Credits4()
    {
        SceneManager.LoadScene("Credits5");
    }

    public void Credits5()
    {
        SceneManager.LoadScene("Credits");
    }
}