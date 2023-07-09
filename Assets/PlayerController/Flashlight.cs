using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] private GameObject Light;
    [SerializeField] private AudioClip flashlightSound;

    private bool IsOn = false;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Light.gameObject.SetActive(false);
        audioSource = GetComponent<AudioSource>();
        // Assign the flashlightSound clip to the AudioSource
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            audioSource.clip = flashlightSound;
            if (IsOn == false)
            {
                Light.gameObject.SetActive(true);
                IsOn = true;
                audioSource.Play();
            }
            else 
            {
                Light.gameObject.SetActive(false);
                IsOn = false;
                audioSource.Play();
            }
        }
    }
}