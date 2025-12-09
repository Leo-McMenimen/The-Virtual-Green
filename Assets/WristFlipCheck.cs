using UnityEngine;

public class WristMenuController : MonoBehaviour
{
    public Transform rightHand; // The RightHand Controller model
    public GameObject menu;
    public float wristPitchThreshold = 45f;

    void Update()
    {
        Vector3 local = rightHand.localEulerAngles;

        float roll = local.z;
        if (roll > 180) roll -= 360;  // convert to -180 to 180

        // CHANGE THIS LINE ↓↓↓ (flip the comparison)
        bool showMenu = roll < -wristPitchThreshold;

        menu.SetActive(showMenu);
    }
}
