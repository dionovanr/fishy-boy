using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UbahCheckpoint : MonoBehaviour
{
    public GameObject deadZone;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(deadZone);
            Destroy(gameObject);
        }
    }
}
