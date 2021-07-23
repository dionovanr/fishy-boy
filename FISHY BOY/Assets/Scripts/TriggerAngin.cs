using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAngin : MonoBehaviour
{
    public GameObject triggerAngin;

    // Start is called before the first frame update
    void Start()
    {
        GameObject wind = GameObject.FindWithTag("Baling-Baling2");
        wind.GetComponent<RotateObject>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.name == "Balok" || col.gameObject.tag == "Player")
        {
            triggerAngin.SetActive(true);
            GameObject wind = GameObject.FindWithTag("Baling-Baling2");
            wind.GetComponent<RotateObject>().enabled = true;
        }
        triggerAngin.SetActive(true);
        

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Balok" || other.gameObject.tag == "Player")
        {
            triggerAngin.SetActive(false);
            GameObject wind = GameObject.FindWithTag("Baling-Baling2");
            wind.GetComponent<RotateObject>().enabled = false;
        }
        
    }
}
