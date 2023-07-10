using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] cubePrefabs;
    
    [SerializeField]
    public int currentCubeIndex = 0;
    
    // Update is called once per frame
    void Update()
    {
        handleCurrentIndex();
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(cubePrefabs[currentCubeIndex], transform.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("Right mouse click");
        }
    }

    void handleCurrentIndex()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentCubeIndex = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentCubeIndex = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentCubeIndex = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentCubeIndex = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            currentCubeIndex = 4;
        }
    }
}
