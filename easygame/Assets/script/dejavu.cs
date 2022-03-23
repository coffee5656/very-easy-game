using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dejavu : MonoBehaviour
{
    public Transform player;
    public GameObject Creation;
    public bool createEnemy = false;
    public GameObject DeJaVu;
    public AudioSource audiosource;
    public AudioClip impact;

    void Update()
    {
        if (player.transform.position.x >= Creation.transform.position.x && createEnemy == false)
        {
            {
                Instantiate(DeJaVu, this.transform.position, Quaternion.identity);
                audiosource.PlayOneShot(impact);
                createEnemy = true;
                
            }
        }
    }
}
