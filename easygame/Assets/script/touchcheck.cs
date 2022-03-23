using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchcheck : MonoBehaviour
{
    public GameObject invisibletile;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            invisibletile.SetActive(true);
        }
    }
}
