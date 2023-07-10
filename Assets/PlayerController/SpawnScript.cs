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
    
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleCurrentIndex();
        HandleCubeIcons();
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            audioSource.PlayOneShot(sphereSpawnAudioClip);
            Instantiate(cubePrefabs[currentCubeIndex], transform.position, Quaternion.identity);
        }

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
    
    private void HandleCubeIcons()
    {
        // Loop through all the cube icons and set their color based on the currently chosen cube index
        for (int i = 0; i < cubeIcons.Length; i++)
        {
            if (i == currentCubeIndex)
            {
                cubeIcons[i].color = Color.yellow; // Highlight the selected cube
            }
            else
            {
                cubeIcons[i].color = Color.white; // Reset the color for non-selected cubes
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
