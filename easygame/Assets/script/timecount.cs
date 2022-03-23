using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timecount : MonoBehaviour
{
    public Text timeCountText;
    public float time_f;
    public int time_i;
    public float startTime;
    

    void Start()
    {
        startTime = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        time_f = Time.time - startTime;
        time_i = Mathf.FloorToInt(time_f);
        timeCountText.text = time_i.ToString();
    }
    public void ResetTime()
    {
        float time = time_f;
        
        
    }
    
}
