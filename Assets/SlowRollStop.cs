using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class GolfBallStopper : MonoBehaviour
{
    public float stopThreshold = 0.05f; // velocity below which to stop
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (rb.linearVelocity.magnitude < stopThreshold)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
