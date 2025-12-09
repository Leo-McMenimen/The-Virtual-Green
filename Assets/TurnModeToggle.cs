using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning;

public class TurnModeToggle : MonoBehaviour
{
    public SnapTurnProvider snapTurn;
    public ContinuousTurnProvider continuousTurn;

    // Call this to enable snap turn
    public void EnableSnapTurn()
    {
        snapTurn.enabled = true;
        continuousTurn.enabled = false;
    }

    // Call this to enable continuous turn
    public void EnableContinuousTurn()
    {
        snapTurn.enabled = false;
        continuousTurn.enabled = true;
    }
}
