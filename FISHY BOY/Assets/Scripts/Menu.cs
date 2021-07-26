using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject pauseMenu;

    public void Stage1()
    {
        SceneManager.LoadScene("STAGE 1");
    }

    public void Stage2()
    {
        SceneManager.LoadScene("STAGE 2");
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Resume()
    {
        GameObject cam = GameObject.FindWithTag("MainCamera");
        cam.GetComponent<CameraMovement>().enabled = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

   

    
}
