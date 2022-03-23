using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gametime : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        gameObject.GetComponent<CanvasGroup>().alpha = 1;

    }
    public void Endgame()
    {
        gameObject.GetComponent<CanvasGroup>().alpha = 0;
    }
}
