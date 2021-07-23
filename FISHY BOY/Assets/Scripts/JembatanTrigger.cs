using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JembatanTrigger : MonoBehaviour
{
    public GameObject Jembatan, jembatanFalse, jembatanAwal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Jembatan.SetActive(true);
            jembatanFalse.SetActive(false);
            jembatanAwal.SetActive(false);
        }
    }
}
