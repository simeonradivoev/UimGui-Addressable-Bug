using ImGuiNET;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoWindow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<UImGui.UImGui>().Layout += gui =>
        {
            ImGui.ShowDemoWindow();
        };
    }
}
