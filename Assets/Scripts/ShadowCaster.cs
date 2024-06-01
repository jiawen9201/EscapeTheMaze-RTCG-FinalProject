using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowCaster : MonoBehaviour
{
    public float maxDistance = 2.5f;
    private Renderer objectRenderer;

    void Start()
    {   
        objectRenderer = GetComponent<Renderer>();

        if (objectRenderer == null)
        {
            Debug.LogWarning("Renderer component not found on the GameObject.");
        }
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, Camera.main.transform.position);

        if (objectRenderer != null)
        {
            if (distance < maxDistance)
            {
                objectRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            }
            else
            {
                objectRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            }
        }
    }
}
