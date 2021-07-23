using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalokBiru : MonoBehaviour
{
    public static bool biruMatched;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Balok Biru")
        {
            biruMatched = true;
        }
    }
}
