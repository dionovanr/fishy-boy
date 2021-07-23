using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    public GameObject Platform;
    public float waktu;
    bool isEnable;
    //public float waktuSpawn;

    // Start is called before the first frame update
    void Start()
    {
        EnablePlatform();
    }

    // Update is called once per frame
    void Update()
    {
       if (isEnable)
        {
            Invoke("DestroyPlatform", waktu);
        }
       
    }

    void EnablePlatform()
    {
        Platform.SetActive(true);
        isEnable = true;
    }

    void DestroyPlatform()
    {
        Platform.SetActive(false);
        Invoke("EnablePlatform", waktu);
    }
}
