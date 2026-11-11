using Unity.Cinemachine;
using UnityEngine;

[RequireComponent (typeof(Collider2D))]
public class CamChangeTrigger : MonoBehaviour
{
    public CinemachineCamera cam1, cam2;
    public const int activePriority = 5000;
    public const int inactivePriority = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 0) { // player
            cam1.Priority = inactivePriority;
            cam2.Priority = activePriority;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == 0) { // player
            cam1.Priority = activePriority;
            cam2.Priority = inactivePriority;
        }
    }
}
