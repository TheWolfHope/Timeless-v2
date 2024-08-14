using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TemporizadorScript : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float remainigngTime;

    private void Update()
    {
        if (remainigngTime > 0)
        {
            remainigngTime -= Time.deltaTime;
        }
        else if (remainigngTime < 0)
        {
            remainigngTime = 0;
            timerText.color = Color.red;
           
        }
        
        int minutes = Mathf.FloorToInt(remainigngTime / 60);
        int seconds = Mathf.FloorToInt(remainigngTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
