using UnityEngine;

[RequireComponent (typeof(Collider2D))]
public class TimeScaleTrigger : MonoBehaviour
{
    public CamManager camManager;
    public bool isSlowMo = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 0) { // player
            camManager.SetGameSpeed(isSlowMo ? 0.5f : 2.0f);
        } 
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == 0) { // player
            camManager.SetGameSpeed(1.0f);
        }
    }
}
