using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public GameObject objek1, objek2, objek3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(objek1);
            Destroy(objek2);
            Destroy(objek3);
        }
    }
}
