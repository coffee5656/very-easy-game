using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeTilePoint2 : MonoBehaviour
{
    public Transform FakeTile;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FakeTile.transform.Translate(2f, 0, 0);
            
        }
    }
}
