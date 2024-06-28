using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOffPortalCulling : MonoBehaviour
{
    public GameObject toggler;

    void Update()
    {
        if (Input.GetKeyDown("o"))
        {
            Debug.Log("O pressed");
            toggler.GetComponent<Toggle>().isOn = true;
            GetComponent<Camera>().useOcclusionCulling = true;
        }
        else if (Input.GetKeyDown("p"))
        {
            Debug.Log("P pressed");
            toggler.GetComponent<Toggle>().isOn = false;
            GetComponent<Camera>().useOcclusionCulling = false;
        }
    }
}
