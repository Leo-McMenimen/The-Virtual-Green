using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning;

public class ContinuousTurnSpeedAdjust : MonoBehaviour
{
    public ContinuousTurnProvider continuousTurnProvider;
    public float increment = 30f;   // Degrees per second to add/remove
    public float minSpeed = 30f;    // Minimum turn speed
    public float maxSpeed = 180f;   // Maximum turn speed

    public void IncreaseTurnSpeed()
    {
        continuousTurnProvider.turnSpeed += increment;
        if (continuousTurnProvider.turnSpeed > maxSpeed)
            continuousTurnProvider.turnSpeed = maxSpeed;

        Debug.Log("Continuous Turn Speed: " + continuousTurnProvider.turnSpeed);
    }

    public void DecreaseTurnSpeed()
    {
        continuousTurnProvider.turnSpeed -= increment;
        if (continuousTurnProvider.turnSpeed < minSpeed)
            continuousTurnProvider.turnSpeed = minSpeed;

        Debug.Log("Continuous Turn Speed: " + continuousTurnProvider.turnSpeed);
    }
}
