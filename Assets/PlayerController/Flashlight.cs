using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] private GameObject Light;
    private bool IsOn = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Light.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (IsOn == false)
            {
                Light.gameObject.SetActive(true);
                IsOn = true;
            }
            else 
            {
                
                Light.gameObject.SetActive(false);
                IsOn = false;
            }
        }
    }
}
