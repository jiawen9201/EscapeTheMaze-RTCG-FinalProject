using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintTrigger : MonoBehaviour
{
    public TextMeshProUGUI hintText;

    void Start()
    {
        displayNull();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with: " + other.gameObject.name);

        if (other.CompareTag("Player"))
        {
            displayInteractionText();
        }
    }

    void OnTriggerExit(Collider other)
    {
        displayNull();
    }

    void displayInteractionText()
    {        
        hintText.text = "Click \"Z\" to view hint";
    }

    void displayNull()
    {        
        hintText.text = "";
    }
}
