using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning;

public class TurnModeToggle : MonoBehaviour
{
    public SnapTurnProvider snapTurnProvider;
    public ContinuousTurnProvider continuousTurnProvider;

    void Start()
    {
        // Start with Snap Turn enabled
        snapTurnProvider.enabled = true;
        continuousTurnProvider.enabled = false;
    }

    public void ToggleTurnMode()
    {
        if (snapTurnProvider.enabled)
        {
            // Switch to Continuous Turn
            snapTurnProvider.enabled = false;
            continuousTurnProvider.enabled = true;
        }
        else
        {
            // Switch to Snap Turn
            snapTurnProvider.enabled = true;
            continuousTurnProvider.enabled = false;
        }
    }
}
