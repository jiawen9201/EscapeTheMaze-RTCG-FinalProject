using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GetTimeToEscape : MonoBehaviour
{
    public TextMeshProUGUI timeTaken;

    void Start()
    {
        if (PlayerPrefs.GetInt("timetaken") < PlayerPrefs.GetInt("bestscore"))
        {
            PlayerPrefs.SetInt("bestscore", PlayerPrefs.GetInt("timetaken"));
        }
        else if (PlayerPrefs.GetInt("bestscore") == 0)
        {
            PlayerPrefs.SetInt("bestscore", PlayerPrefs.GetInt("timetaken"));
        }
        timeTaken.text = "Time Taken to escape: " + PlayerPrefs.GetInt("timetaken".ToString()) + " seconds";
    }
}
