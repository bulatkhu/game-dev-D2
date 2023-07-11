using UnityEngine;

public class ChangeSkybox : MonoBehaviour
{
    public Material daySkybox;
    public Material nightSkybox;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            RenderSettings.skybox = nightSkybox;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            RenderSettings.skybox = daySkybox;
        }
    }
}