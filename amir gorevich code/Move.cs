using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Move : MonoBehaviour
{
    public Touch touch;
    public bool PowerUp = false;
    public float speedModifier;
    public float timer = 0.0f;
    public float moveSpeed = 22f;
    public float newSpeed = 0.12f;
    public Rigidbody rb;

    public float jump;

    public PauseMenu pauseMenu;
    Animator anim;
    void Start()
    {
        speedModifier = newSpeed;

        rb = GetComponent<Rigidbody>();

    }


    // Update is called once per frame
    void Update()
    {
        
        transform.position += Vector3.forward * Time.deltaTime * moveSpeed;
        
        if (Input.touchCount > 0)
        {

            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedModifier,transform.position.y,transform.position.z);

            }

        }

            Invoke("startMove", 5);
     

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Snowman")
        {
            moveSpeed = moveSpeed-20;

        }
        if (collision.gameObject.tag == "Fish")
        {
        
            StartPowerUp();

        }
        if (collision.gameObject.tag == "Mountain")
        {

            Time.timeScale = 0f;
            pauseMenu.GameOver();

        }

        if (collision.gameObject.tag == "WinZone")
        {

            Time.timeScale = 0f;
            pauseMenu.GameWon();

        }

    }



    public void startMove()
    {
        moveSpeed = moveSpeed - 0.05f;

        if (moveSpeed <= 20)
        {
            moveSpeed = 19f;

        }
    }
    public void StartPowerUp()
    {
        jump = Random.Range(70, 130);
        moveSpeed = moveSpeed + 30;
        rb.AddForce(new Vector3(0, jump, 0), ForceMode.Impulse);
        
    }

   


}
