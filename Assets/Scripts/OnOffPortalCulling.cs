using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOffPortalCulling : MonoBehaviour
{
    public GameObject toggler;
    public static bool cullingIsOff;

    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            cullingIsOff = !cullingIsOff;  
        }
        Culling();
    }

    void Culling()
    {
        if (!cullingIsOff)
        {
            toggler.GetComponent<Toggle>().isOn = true;
            GetComponent<Camera>().useOcclusionCulling = true;
        }
        else
        {
            toggler.GetComponent<Toggle>().isOn = false;
            GetComponent<Camera>().useOcclusionCulling = false;
        }
    }
}
