using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject cubePrefab;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(cubePrefab, transform.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("Right mouse click");
        }
    }
}
