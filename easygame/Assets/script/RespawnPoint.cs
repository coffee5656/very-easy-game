using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    public Movement thePlayer;
    public Animator animator;
    bool i = false;
    // Start is called before the first frame update
    void Start()
    {
        Movement thePlayer = FindObjectOfType<Movement>();
    }

    

  public void Respawn()
    {
        StartCoroutine("RespawnCo");
    }

    public IEnumerator RespawnCo()
    {
        thePlayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);

        thePlayer.transform.position = thePlayer.RespawnPosition;
        //把復活點的位置傳給角色，讓角色在復活點復活

        thePlayer.gameObject.SetActive(true);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (i == false)
            {
                animator.SetBool("Check", true);
                i = true;
            }   
            
        }
    }
}
