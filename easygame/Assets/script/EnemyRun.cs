using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRun : MonoBehaviour
{
    public Rigidbody2D rb;
    public float MoveSpeed = 30f;
    
    // Update is called once per frame
    void Update()
    {
      transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);
        transform.localScale = new Vector2(-1f, 1f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
