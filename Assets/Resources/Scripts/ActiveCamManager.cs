using UnityEngine;
using Unity.Cinemachine;

public class CamManager : MonoBehaviour
{
    public CinemachineCamera[] cams;
    public int activeIdx = 0;

    void Start()
    {
        if (cams == null) {
            Debug.LogError("CamManager: cams is null!");
            return;
        }
        for (int i = 0; i < cams.Length; i++) {
            var cam = cams[i];
            if (cam == null) { Debug.LogError("Cam " + i + " is null!"); }            
        }
        SetActiveCam(activeIdx);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha0)) {
            SetActiveCam(0);
        } else if (Input.GetKey(KeyCode.Alpha3)) {
            SetActiveCam(3);
        }
    }

    public void SetActiveCam(int index) {
        activeIdx = index;
        for (int i = 0; i < cams.Length; i++) {
            cams[i].gameObject.SetActive(i == index);
        }
    }
}
