using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int nextSceneLoad;
    public GameObject pauseMenu;

    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

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
        SceneManager.LoadScene("STAGE 3");
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

   public void NextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3 ) /* < Change this int value to whatever your
                                                                   last level build index is on your
                                                                   build settings */
        {
            Debug.Log("You Completed ALL Levels");
            //Show Win Screen or Somethin. 
        }
        else
        {
            //Move to next level
            SceneManager.LoadScene(nextSceneLoad);

            //Setting Int for Index
            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }
        }
    }

    
}
