using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Movement : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public bool isGround;
    public float JumpSpeed;
    public Animator animator;
    public float MoveSpeed = 5.0f;
    AudioSource audiosource;
    public AudioClip jump;
    public endtime end;
    public gametime game;
    public GameManager gamemanager;
    public GameObject cam;
    public int hitted;

    //public Joystick joystick;
    public Vector2 RespawnPosition;

    //public RespawnPoint theLevel;
    
    //在角色下新增一個空物體
    //設定一個跳躍監測點
    public Transform CheckPoint;
    //設定一個跳躍監測半徑
    public float CheckRadius;
    //設定一個跳躍監測層---角色與地面的檢測
    public LayerMask WhatIsGround;

    void Start()
    {
        audiosource = gameObject.GetComponent<AudioSource>();
        RespawnPosition = transform.position;
        //theLevel = FindObjectOfType<RespawnPoint>();
        end = FindObjectOfType<endtime>();
        game = FindObjectOfType<gametime>();
        
        Time.timeScale = 1f;
    }
    void Update()
    {
        //檢查用
        isGround = Physics2D.OverlapCircle(CheckPoint.position, CheckRadius, WhatIsGround);
        //float verticalMove = joystick.Vertical;
        //手機板joystick

        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpSpeed);
            animator.SetBool("IsJumping", true);
            audiosource.PlayOneShot(jump);
        }

        //if (joystick.Horizontal >= 0.2f)
        //手機板向右
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(MoveSpeed, rb.velocity.y);
            transform.localScale = new Vector2(1f, 1f);


        }
        //角色水平移動
        //按住A鍵，判斷如果小於0，則向左開始移動
        //else if (joystick.Horizontal<=-0.2f)
        //手機板向左
        else if (Input.GetKey(KeyCode.LeftArrow))
        {

            rb.velocity = new Vector2(-MoveSpeed, rb.velocity.y);
            transform.localScale = new Vector2(-1f, 1f);

        }
        else
        //角色水平移動
        //鬆開按鍵，判斷如果等於0，則停止移動
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));

        if (gameObject.transform.position.y <= -10f)
        {
            FindObjectOfType<PlayerDie>().EndGame();
        }
        if (hitted >= 1)
        {
            CheckRadius = 0;
        }
        
    }
    //public void jumpButton()
    //{
    //if (isGround)
    //{
    //rb.velocity = new Vector2(rb.velocity.x, JumpSpeed) ;
    //animator.SetBool("IsJumping", true);
    //audiosource.PlayOneShot(jump);
    //}
   // }
    //手機版跳躍
    


    public  void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            animator.SetBool("IsJumping", false);
        }

        if (collision.gameObject.tag == "enemy")
        {
            GameManager.Instance.death++;
            FindObjectOfType<PlayerDie>().Die();
            rb.AddForce(new Vector2(-30f, 20f), ForceMode2D.Impulse);
            hitted++;
            MoveSpeed = 0f;
            //theLevel.Respawn();
        }
    }
    public void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "End")
        {
            Time.timeScale = 0f;
            end.Endgame();
            game.Endgame();
        }
        if (trigger.gameObject.tag == "enemy")
        {
            //theLevel.Respawn();
            GameManager.Instance.death++;
            FindObjectOfType<PlayerDie>().Die();
            rb.AddForce(new Vector2(-30f, 20f), ForceMode2D.Impulse);
            hitted++;
            MoveSpeed = 0f;
        }

        //if (trigger.gameObject.tag == "RespawnPoint")
       // {
       //     RespawnPosition = trigger.transform.position;
       // }

    }
    
}



