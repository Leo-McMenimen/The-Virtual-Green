using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning;

public class TurnModeToggleXR3 : MonoBehaviour
{
    public SnapTurnProvider snapProvider;
    public ContinuousTurnProvider continuousProvider;

    void Start()
    {
        snapProvider.enabled = true;
        continuousProvider.enabled = false;
    }

    public void UseSnapTurn()
    {
        snapProvider.enabled = true;
        continuousProvider.enabled = false;
    }

    public void UseContinuousTurn()
    {
        snapProvider.enabled = false;
        continuousProvider.enabled = true;
    }
}
