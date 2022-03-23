using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeTilePoint : MonoBehaviour
{
    public Transform FakeTile;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FakeTile.transform.Translate(-4f, 0, 0);
            
        }
    }
}
