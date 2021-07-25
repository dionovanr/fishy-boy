using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectParent : MonoBehaviour
{
    public Transform Player;


    private void OnTriggerEnter(Collider other)
    {
        other.transform.parent = transform;
        if (Player.gameObject.tag == "Lantai")
        {
            other.transform.parent = null;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.parent = null;
    }
}
