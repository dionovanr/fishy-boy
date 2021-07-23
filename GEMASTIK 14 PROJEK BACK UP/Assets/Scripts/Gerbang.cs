using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerbang : MonoBehaviour
{
    public GameObject KeyUI;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" && KeyItem.kunci>0)
        {
            KeyItem.kunci--;
            Destroy(gameObject);
            KeyUI.SetActive(false);
        }
    }
}
