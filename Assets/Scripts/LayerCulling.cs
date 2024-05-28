using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerCulling : MonoBehaviour
{ 
    public float cube;
    public float sphere;
    // Update is called once per frame
    void Update()
    {
        Camera camera = GetComponent<Camera>();
        float[] distances = new float[32];
        distances[6] = cube;
        distances[7] = sphere;
        camera.layerCullDistances = distances;
    }
}
