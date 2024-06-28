using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnOffPortalCulling : MonoBehaviour
{
    public GameObject toggler;
    public static bool cullingIsOn;

    void Start()
    {
        cullingIsOn = true;
    }

    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            cullingIsOn = !cullingIsOn;  
        }
        Culling();
    }

    void Culling()
    {
        if (cullingIsOn)
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
