using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float currentTime = 0;
    public float startingTime;

    public Text timerText;
    public GameObject GameOverUI;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            Time.timeScale = 0;
            GameOverUI.SetActive(true);
            //BackgroundMusic.Stop();

            //GameObject cam = GameObject.FindWithTag("MainCamera");
            //cam.GetComponent<CameraMovement>().enabled = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            SkorManager.score = 0;
        }
    }
}
