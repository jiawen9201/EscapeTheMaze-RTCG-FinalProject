using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CulledObjectShadowCast : MonoBehaviour
{
    public LayerMask culledLayer;
    // Start is called before the first frame update
    void Start()
    {
        Renderer[] culledRenderers = FindObjectsOfType<Renderer>().Where(culledRenderers => culledLayer == (culledLayer | (1 << culledRenderers.gameObject.layer))).ToArray();

        foreach (Renderer renderer in culledRenderers)
        {
            renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
