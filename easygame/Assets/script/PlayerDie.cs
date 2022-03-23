using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDie : MonoBehaviour
{
    public GameObject cam;
    public Animator animator;
    public Rigidbody2D rb;
    public float MoveSpeed = 5f;
    public bool gameHasEnded = false;
    public AudioSource audiosource;
    public AudioClip die;


    public void Die()
    {
        cam.SetActive(false);
        animator.SetBool("IsDead", true);
        GetComponent<Collider2D>().enabled = false;
        audiosource.PlayOneShot(die);
        
    }
    
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
