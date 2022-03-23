using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endtime : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip endsound;

    // Start is called before the first frame update
    public void Start()
    {
        gameObject.GetComponent<CanvasGroup>().alpha = 0;
        
    }
    public void Endgame()
    {
        audiosource.PlayOneShot(endsound);
        gameObject.GetComponent<CanvasGroup>().alpha = 1;
    }
}
