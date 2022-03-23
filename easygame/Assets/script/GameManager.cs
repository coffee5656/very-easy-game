using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public float time_f;
    public int time_i;
    public int death;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        time_f = Time.time;
        time_i = Mathf.FloorToInt(time_f);
    }
    public void ResetTime()
    {
        
    }
}

