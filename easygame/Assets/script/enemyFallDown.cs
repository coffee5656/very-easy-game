using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFallDown : MonoBehaviour
{
    public GameObject Creation;
    public Transform player;
    public GameObject enemyPrefab;
    public bool createEnemy=false;

    void Update()
    {
        if (player.transform.position.x >= Creation.transform.position.x && createEnemy == false) 
        {
            {
                Instantiate(enemyPrefab, this.transform.position, Quaternion.identity);
                createEnemy = true;
                //1.因為是Update()，所以下一格又會跑去執行if的判斷
                //2.然後因為變成true了，所以不會執行if的判斷
            }
        }
        //else
        //{
        //createEnemy = false;
        //}
        //3.如果寫了else，就會變成if的結果不是false，所以執行else
        //4.然後else執行因為是false，所以又回去執行if，就這樣無限輪迴

    }

}
