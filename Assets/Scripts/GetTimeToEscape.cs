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
        timeTaken.text = "Time Taken to escape: " + PlayerPrefs.GetInt("timetaken".ToString()) + " seconds";
    }
}
