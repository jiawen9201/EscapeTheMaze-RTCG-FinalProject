using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeCountdown : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public float duration, currentTime;
    string unit = "seconds";

    // Start is called before the first frame update
    void Start()
    {
        currentTime = duration;
        timeText.text = "Time remaining: " + currentTime.ToString() + unit;
        StartCoroutine(TimeUpdate());
    }

    // Update is called once per frame
    IEnumerator TimeUpdate()
    {
        while (currentTime >= 0)
        {
            if (currentTime == 1)
                unit = "second";
            if (currentTime == 10)
                timeText.color = new Color (1, 0, 0, 1f);
            timeText.text = "Time remaining: " + currentTime.ToString() + " " + unit;
            yield return new WaitForSeconds(1f);
            currentTime -= 1;
        }
    }
}
