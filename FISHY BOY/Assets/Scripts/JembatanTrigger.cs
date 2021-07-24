using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JembatanTrigger : MonoBehaviour
{
    public GameObject JembatanYangDipanggil, jembatanFalse1, jembatanAwal, jembatanFalse2;
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
            JembatanYangDipanggil.SetActive(true);
            jembatanFalse1.SetActive(false);
            jembatanAwal.SetActive(false);
            jembatanFalse2.SetActive(false);
        }
    }
}
