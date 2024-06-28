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
            toggler.GetComponent<Toggle>().isOn = true;
            GetComponent<Camera>().useOcclusionCulling = true;
        }
        else if (Input.GetKeyDown("p"))
        {
            toggler.GetComponent<Toggle>().isOn = false;
            GetComponent<Camera>().useOcclusionCulling = false;
        }
    }
}
