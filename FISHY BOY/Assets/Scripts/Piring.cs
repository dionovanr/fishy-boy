using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piring : MonoBehaviour
{
    public GameObject objek;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Buah1" && other.gameObject.name == "Buah2" && other.gameObject.name == "Buah3")
        {
            Destroy(objek);
        }
    }
}
