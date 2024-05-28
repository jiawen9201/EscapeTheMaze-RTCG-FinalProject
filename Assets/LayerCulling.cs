using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerCulling : MonoBehaviour
{ 
    public int cube = 15;
    public int sphere = 10;
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
