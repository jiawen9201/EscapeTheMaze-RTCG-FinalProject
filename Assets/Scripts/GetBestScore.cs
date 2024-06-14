using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GetBestScore : MonoBehaviour
{
    public TextMeshProUGUI bestScore;

    void Start()
    {   if (PlayerPrefs.GetInt("bestscore") == 0)
            bestScore.text = "No record";
        else
            bestScore.text = PlayerPrefs.GetInt("bestscore".ToString()) + " seconds";
    }
}
