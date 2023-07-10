using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves the other object
        if (collision.gameObject.CompareTag("Cube") && !gameObject.CompareTag("Cube")) // Replace "Cube" with the appropriate tag of your cube object
        {
            // Play the sound effect
            AudioManager.instance.audioSource.PlayOneShot(AudioManager.instance.collision);
        }
    }
}
