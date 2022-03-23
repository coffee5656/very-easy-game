using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public Text timeText;
    public Text deathcountText;
    public Text endtimeText;
    public Text FinalDeathCountText;
    private void Update()
    {
        timeText.text = GameManager.Instance.time_i.ToString();
        deathcountText.text = GameManager.Instance.death.ToString();
        endtimeText.text = GameManager.Instance.time_i.ToString();
        FinalDeathCountText.text = GameManager.Instance.death.ToString();
    }

}

