using UnityEngine.UI;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] cubePrefabs;
    public GameObject spherePrefab;
    public float forceMagnitude = 25f; // Adjust this value as needed
    public Image[] cubeIcons;
    [SerializeField] public int currentCubeIndex = 0;

    private AudioSource audioSource;
    [SerializeField] private AudioClip sphereSpawnAudioClip;
    [SerializeField] private AudioClip cubeSpawnAudioClip;
    [SerializeField] private AudioClip selectCubeTypeAudioClip;

    private GameObject heldCube = null;
    private bool isHoldingCube = false;
    
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleCurrentIndex();
        HandleCubeIcons();
        HandleCubeSpawning();

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            audioSource.PlayOneShot(cubeSpawnAudioClip);
            GameObject sphere = Instantiate(spherePrefab, transform.position, Quaternion.identity);
            Rigidbody sphereRigidbody = sphere.GetComponent<Rigidbody>();
            // Apply a forward force to the sphere
            Vector3 forceDirection = transform.forward; // Use the player's forward direction
            Vector3 force = forceDirection * forceMagnitude;
            sphereRigidbody.AddForce(force, ForceMode.Impulse);
        }
    }

    private void HandleCubeSpawning()
    {
        // If we're holding a cube, keep it in front of the player
        if(isHoldingCube)
        {
            heldCube.transform.position = transform.position + transform.forward * 2;
        }

        if (Input.GetKeyUp(KeyCode.Mouse0) && isHoldingCube)
        {
            DropTheCube();
        }
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // If we're currently holding a cube
            if(isHoldingCube)
            {
                DropTheCube();
            }
            // Otherwise, spawn or pick up a cube
            else
            {
                // Raycast forward from the player's position
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.forward, out hit, 5f)) // Adjust distance as needed
                {
                    // If we hit a cube, pick it up
                    if (hit.transform.gameObject.CompareTag("Cube")) // Make sure your cubes are tagged appropriately in Unity
                    {
                        audioSource.PlayOneShot(sphereSpawnAudioClip);
                        heldCube = hit.transform.gameObject;
                        Rigidbody cubeRigidbody = heldCube.GetComponent<Rigidbody>();
                        cubeRigidbody.isKinematic = true; // Disable physics
                        isHoldingCube = true;
                    }
                }
                // If we didn't hit anything, spawn a cube
                else
                {
                    audioSource.PlayOneShot(sphereSpawnAudioClip);
                    heldCube = Instantiate(cubePrefabs[currentCubeIndex], transform.position + transform.forward * 2, Quaternion.identity); // Spawn the cube 2 units in front of the player
                    Rigidbody cubeRigidbody = heldCube.GetComponent<Rigidbody>();
                    cubeRigidbody.isKinematic = true; // Disable physics
                    isHoldingCube = true;
                }
            }
        }
    }

    private void DropTheCube()
    {
        // Drop the cube
        Rigidbody cubeRigidbody = heldCube.GetComponent<Rigidbody>();
        cubeRigidbody.isKinematic = false; // Enable physics
        heldCube = null; // We're no longer holding a cube
        isHoldingCube = false;
    }
    
    private void HandleCubeIcons()
    {
        // Loop through all the cube icons and set their color based on the currently chosen cube index
        for (int i = 0; i < cubeIcons.Length; i++)
        {
            if (i == currentCubeIndex)
            {
                Outline outline = cubeIcons[i].GetComponent<Outline>();
                if(outline != null)
                {
                    // Set the new color
                    outline.effectColor = new Color(0, 0, 0, 1);
                }
                // cubeIcons[i].color = Color.yellow; // Highlight the selected cube
            }
            else
            {
                Outline outline = cubeIcons[i].GetComponent<Outline>();
                if(outline != null)
                {
                    // Set the new color
                    outline.effectColor = new Color(0, 0, 0, 0);
                }
                // cubeIcons[i].color = Color.white; // Reset the color for non-selected cubes
            }
        }
    }

    private void HandleCurrentIndex()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentCubeIndex = 0;
            audioSource.PlayOneShot(selectCubeTypeAudioClip);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentCubeIndex = 1;
            audioSource.PlayOneShot(selectCubeTypeAudioClip);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentCubeIndex = 2;
            audioSource.PlayOneShot(selectCubeTypeAudioClip);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentCubeIndex = 3;
            audioSource.PlayOneShot(selectCubeTypeAudioClip);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            currentCubeIndex = 4;
            audioSource.PlayOneShot(selectCubeTypeAudioClip);
        }
    }
}
