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
    public GameObject statisticWindow;
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
        if (trianglesRecorder.Valid)
            trisText.text = "Triangles: " + trianglesRecorder.LastValue.ToString();
        if (verticesRecorder.Valid)
            vertsText.text = "Vertices: " + verticesRecorder.LastValue.ToString();

        if (Input.GetKeyDown("g"))
        {
            toggler.GetComponent<Toggle>().isOn = true;
            statisticWindow.SetActive(true);
        }
        else if (Input.GetKeyDown("h"))
        {
            toggler.GetComponent<Toggle>().isOn = false;
            statisticWindow.SetActive(false);
        }
    }
}
