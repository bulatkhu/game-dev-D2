using UnityEngine;

public class ChangeSkybox : MonoBehaviour
{
    public Light targetLight;
    public float nightRotationSpeed = 0.5f;
    public Material daySkybox;
    public Material nightSkybox;

    private bool isDaytime = true;
    
    void Start()
    {
        // Ensure you have a reference to the target light component
        if (targetLight == null)
        {
            targetLight = GetComponent<Light>();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SetNighttime();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            SetDaytime();
        }
   
        // float rotationSpeed = isDaytime ? dayRotationSpeed : nightRotationSpeed;
        // sunTransform.Rotate(Vector3.right * (rotationSpeed * Time.deltaTime));
        // // Check sun's rotation angle to switch skybox
        // if (sunTransform.rotation.eulerAngles.x >= 180 && isDaytime)
        // {
        //     SetNighttime();
        // }
        // else if (sunTransform.rotation.eulerAngles.x < 180 && !isDaytime)
        // {
        //     SetDaytime();
        // }
    }
   
    void SetDaytime()
    {
        if (isDaytime)
        {
            return;
        }
        
        isDaytime = true;
        RenderSettings.skybox = daySkybox;
        transform.Rotate(Vector3.right * 180);
        targetLight.intensity = 2;
    }
   
    void SetNighttime()
    {
        if (!isDaytime)
        {
            return;
        }
        
        isDaytime = false;
        RenderSettings.skybox = nightSkybox;
        transform.Rotate(Vector3.left * 180);
        targetLight.intensity = 0;
    }
}