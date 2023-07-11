using UnityEngine;

public class BackgroundMusicController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            if (audioClip == audioSource.clip)
            {
                return;
            }
            
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }
}
