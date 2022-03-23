﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearTile : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
        }
    }
}
