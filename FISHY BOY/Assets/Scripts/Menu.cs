using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Stage1()
    {
        SceneManager.LoadScene("STAGE 1");
    }

    public void Stage2()
    {

    }

    public void Stage3()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("STAGE 1");
    }
}
