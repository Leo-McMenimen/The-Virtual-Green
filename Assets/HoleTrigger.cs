using UnityEngine;

public class HoleTrigger : MonoBehaviour
{
    public AudioSource holeSound; // assign in inspector

    private void OnTriggerEnter(Collider other)
    {
        // Play sound whenever something enters the trigger
        holeSound.Play();

    }
}
