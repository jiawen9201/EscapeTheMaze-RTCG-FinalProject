using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerCulling : MonoBehaviour
{ 
    public float hint;
    // Update is called once per frame
    void Update()
    {
        Camera camera = GetComponent<Camera>();
        float[] distances = new float[32];
        distances[6] = hint;
        camera.layerCullDistances = distances;
    }
}
