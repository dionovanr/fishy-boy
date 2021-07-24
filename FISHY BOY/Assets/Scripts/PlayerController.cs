using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 jump;
    public float jumpForce, angin;
    Rigidbody rb;
    public GameObject cam1, cam2, cam3, triggerAngin, DeathZone3, winUI, jawaban1, jawaban2, gerbang, switchButtonOn, switchButtonoff;
    public AudioSource clickButton, deathSound, BackgroundMusic;

    bool isGround, jawabanBenar;

    Vector3 forward, right;

    [Space(15)]
    public float checkDistance;
    public Transform GroundCheck;
    public LayerMask GroundMask;

    [Space(15)]
    public Transform PlayerMesh;

    [Space(15)]
    public bool canJump;
    public bool canMove;

    int Health = 5;
    int score;
    public Text scoreText, healthText;
    public GameObject GameOverUI;

    public Animator papanTulisAnim;

    // Start is called before the first frame update
    void Start()
    {
        jump = new Vector3(0f, 2f, 0f);
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;

        Time.timeScale = 1;

        healthText.text = "Health: " + Health.ToString();

        GameObject wind = GameObject.FindWithTag("Baling-Baling");
        wind.GetComponent<RotateObject>().enabled = false;

        papanTulisAnim = GetComponent<Animator>();

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        Vector3 MoveDirection = forward * verticalInput + right * horizontalInput;

        rb.velocity = new Vector3(MoveDirection.x * moveSpeed, rb.velocity.y, MoveDirection.z * moveSpeed);

        if (MoveDirection != new Vector3(0, 0, 0))
        {
            PlayerMesh.rotation = Quaternion.LookRotation(MoveDirection);
        }

    }

    private void Update()
    {
        PlayerJump();
        //canJump = Physics.CheckSphere(GroundCheck.position, checkDistance, GroundMask);

        //if (canJump && Input.GetButtonDown("Jump"))
        //{
        //    Rigidbody rb = GetComponent<Rigidbody>();
        //    rb.velocity = Vector3.up * jumpForce;
        //}
    }

    void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("HorizontalKey"), 0, Input.GetAxis("VerticalKey"));
        Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxis("HorizontalKey");
        Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("VerticalKey");

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        transform.forward = heading;
        transform.position += rightMovement;
        transform.position += upMovement;
    }

    void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGround = false;
        }

    }

    private void OnTriggerEnter(Collider col)
    {
        //if (col.gameObject.tag == "Obstacle")
        //{
        //    Time.timeScale = 0;
        //}

        if (col.gameObject.tag == "Camera Trigger1")
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }

        if (col.gameObject.tag == "Camera Trigger2")
        {
            cam2.SetActive(false);
            cam3.SetActive(true);
        }

        if (col.gameObject.tag == "Switch Angin")
        {
            triggerAngin.SetActive(true);

            GameObject wind = GameObject.FindWithTag("Baling-Baling");
            wind.GetComponent<RotateObject>().enabled = true;

            switchButtonOn.SetActive(true);
            switchButtonoff.SetActive(false);

            clickButton.Play();
        }

        if (col.gameObject.tag == "WinZone")
        {
            Destroy(DeathZone3);
        }
        if (col.gameObject.tag == "Win")
        {
            Time.timeScale = 0;
            winUI.SetActive(true);

            GameObject cam = GameObject.FindWithTag("MainCamera");
            cam.GetComponent<CameraMovement>().enabled = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            BackgroundMusic.Stop();
        }

        if (col.gameObject.tag == "Jawaban1")
        {
            jawaban1.SetActive(true);
            jawabanBenar = true;
            Debug.Log("Benar");
            Destroy(gerbang);
            papanTulisAnim.Play("PapanTulisJatoh");
            Destroy(jawaban2);

        }
        if(col.gameObject.tag == "Jawaban2")
        {
            jawaban2.SetActive(true);
            jawabanBenar = false;
            Invoke("matikanObject", 2);
            Debug.Log("Salah");
        }

        if (col.gameObject.tag == "Jembatan1")
        {

        }

        //if (col.gameObject.tag == "Score")
        //{
        //    if (score == +2)
        //    {
        //        score += 1;
        //        scoreText.text = "Score: " + score.ToString();
        //    }
        //    else
        //    {
        //        score++;
        //        scoreText.text = "Score: " + score.ToString();
        //    }
            
           
        //}

        if (col.gameObject.tag == "DeathZone" || col.gameObject.tag == "Obstacle")
        {
            deathSound.Play();
            Health--;
            healthText.text = "Health: " + Health.ToString();

            if (Health <= 0)
            {
                Health = 0;
                healthText.text = "Health: " + Health.ToString();
                Time.timeScale = 0;
                GameOverUI.SetActive(true);
                BackgroundMusic.Stop();

                GameObject cam = GameObject.FindWithTag("MainCamera");
                cam.GetComponent<CameraMovement>().enabled = false;

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                SkorManager.score = 0;

            }
            

        }

        isGround = true;
    }

    //private void OnTriggerExit(Collider col)
    //{
    //    if (col.gameObject.tag == "Camera Trigger1")
    //    {
    //        cam1.enabled = true;
    //        cam2.enabled = false;
    //    }

    //    if (col.gameObject.tag == "Camera Trigger2")
    //    {
    //        cam2.enabled = true;
    //        cam3.enabled = false;
    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Angin")
        {
            rb.AddForce(new Vector3(0, angin, 0), ForceMode.Impulse);
        }
         
        if (other.gameObject.tag == "Angin 2")
        {
            rb.AddForce(new Vector3(0, 1, 0), ForceMode.Impulse);
        }
    }

    void matikanObject()
    {
        jawaban2.SetActive(false);
    }


}
