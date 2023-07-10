using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("--------------- Audio Source ---------------")]
    public AudioSource audioSource;
    
    [Header("--------------- Audio Clip -----------------")]
    public AudioClip collision;

    public static AudioManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void PlaySFX(AudioClip clip)
    {
        Debug.Log(instance);
        
        audioSource.PlayOneShot(clip);
    }
}
