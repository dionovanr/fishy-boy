using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerbang : MonoBehaviour
{
    public GameObject KeyUI, needKeyUI, winUI;
    public AudioSource BackgroundMusic;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" && KeyItem.kunci <= 0)
        {
            needKeyUI.SetActive(true);
            Invoke("DestroyUI", 2);
        }
        if (col.gameObject.tag == "Player" && KeyItem.kunci>0)
        {
            KeyItem.kunci--;
            Destroy(gameObject);
            KeyUI.SetActive(false);
            Time.timeScale = 0;
            winUI.SetActive(true);

            GameObject cam = GameObject.FindWithTag("MainCamera");
            cam.GetComponent<CameraMovement>().enabled = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            BackgroundMusic.Stop();
        }
    }

    void DestroyUI()
    {
        needKeyUI.SetActive(false);
    }
}
