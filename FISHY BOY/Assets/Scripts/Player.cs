using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float jumpForce, angin;
    bool isGround;
    public Transform grabPos;

    RaycastHit hit;
    GameObject grabedObj;
    public GameObject miringKanan, miringKiri, lurus, waktu;

    bool benarKanan, benarLurus, benarKiri;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody>();

        GameObject rotateObject = GameObject.FindWithTag("Object");
        rotateObject.GetComponent<RotateObject>().enabled = false;

        GameObject time = GameObject.FindGameObjectWithTag("Timer");
        time.GetComponent<Timer>().enabled = false;
    }

    private void Update()
    {
        PlayerJump();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();
        

        if (Input.GetMouseButtonDown(0) && Physics.Raycast(transform.position, transform.forward, out hit, 5) && hit.transform.GetComponent<Rigidbody>())
        {
            grabedObj = hit.transform.gameObject;
        }
        else if (Input.GetMouseButtonUp(0)){
            grabedObj = null;
        }
        if (grabedObj)
        {
            grabedObj.GetComponent<Rigidbody>().velocity = 10 * (grabPos.position - grabedObj.transform.position);
        }

        puzzleChecker();

    }

    void PlayerMove()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(h, 0, v) * speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);

        
    }

    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && isGround)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            isGround = false;
        }
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Lantai" || col.gameObject.tag == "PlatformGerak" || col.gameObject.tag == "Platform")
        {
            isGround = true;
        }
        if (col.gameObject.tag == "PlatformGerak")
        {
            GameObject mainCam = GameObject.FindWithTag("MainCamera");
            mainCam.GetComponent<CameraController1>().enabled = false;
            mainCam.GetComponent<FreeCam>().enabled = true;
        }
        if (col.gameObject.tag == "Puzzle Kanan")
        {
            miringKanan.SetActive(true);
            benarKanan = true;
            //puzzleChecker();
        }
        if (col.gameObject.tag == "Puzzle Lurus")
        {
            lurus.SetActive(true);
            benarLurus = true;
            //puzzleChecker();
        }
        if (col.gameObject.tag == "Puzzle Kiri")
        {
            miringKiri.SetActive(true);
            benarLurus = false;
            benarKanan = false;
            Invoke("puzzleCheckerFalse", 3);
        }

        if (col.gameObject.tag == "Obstacle")
        {
            Time.timeScale = 0;
        }

        if (col.gameObject.tag == "Timer")
        {
            GameObject time = GameObject.FindGameObjectWithTag("Timer");
            time.GetComponent<Timer>().enabled = true;
            waktu.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "PlatformGerak")
        {
            GameObject mainCam = GameObject.FindWithTag("MainCamera");
            mainCam.GetComponent<CameraController1>().enabled = true;
            mainCam.GetComponent<FreeCam>().enabled = false;
            
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Angin")
        {
            rb.AddForce(new Vector3(0, angin, 0), ForceMode.Impulse);
        }
    }

    void puzzleChecker()
    {
        if (benarKanan && benarLurus)
        {
            GameObject rotateObject = GameObject.FindWithTag("Object");
            rotateObject.GetComponent<RotateObject>().enabled = true;
        }
        
    }

    void puzzleCheckerFalse()
    {
        if (!benarKanan || !benarLurus)
        {
            miringKanan.SetActive(false);
            lurus.SetActive(false);
            miringKiri.SetActive(false);

            GameObject rotateObject = GameObject.FindWithTag("Object");
            rotateObject.GetComponent<RotateObject>().enabled = false;
        }
    }
}
