using ImGuiNET;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class LoadSceneWindow : MonoBehaviour
{
    public AssetReference Scene;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<UImGui.UImGui>().Layout += gui =>
        {
            ImGui.Begin("Test Window");

            if (ImGui.Button("Load Addressable Scene"))
            {
                Addressables.LoadSceneAsync(Scene);
            }

            ImGui.End();
        };
    }
}
