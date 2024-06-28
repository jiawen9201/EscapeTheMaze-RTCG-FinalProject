using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Unity.Profiling;
using TMPro;

public class PerformanceMonitor : MonoBehaviour
{
    public TextMeshProUGUI trisText;
    public TextMeshProUGUI vertsText;
    public GameObject fpsWindow;
    public GameObject toggler;

    ProfilerRecorder trianglesRecorder;
    ProfilerRecorder verticesRecorder;

    void Start()
    {
        trianglesRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Render, "Triangles Count");
        verticesRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Render, "Vertices Count");
    }

    void Update()
    {
        var sb1 = new StringBuilder(500);
        var sb2 = new StringBuilder(500);
        if (trianglesRecorder.Valid)
            sb1.AppendLine($"Triangles: {trianglesRecorder.LastValue}");
        if (verticesRecorder.Valid)
            sb2.AppendLine($"Vertices: {verticesRecorder.LastValue}");
        trisText.text = sb1.ToString();
        vertsText.text = sb2.ToString();

        if (Input.GetKeyDown("z"))
        {
            toggler.GetComponent<Toggle>().isOn = true;
            fpsWindow.SetActive(true);
        }
        else if (Input.GetKeyDown("x"))
        {
            toggler.GetComponent<Toggle>().isOn = false;
            fpsWindow.SetActive(false);
        }
    }
}
