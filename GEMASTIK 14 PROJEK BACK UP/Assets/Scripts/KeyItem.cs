using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyItem : MonoBehaviour
{
    public static int kunci = 0;
    public Text keyText;
    public GameObject keyUI;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            kunci++;
            Destroy(gameObject);
            keyText.text = "Kunci: " + kunci.ToString();
            keyUI.SetActive(true);
        }
    }
}
