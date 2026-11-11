using UnityEngine;
using Unity.Cinemachine;

public class CamManager : MonoBehaviour
{
    public CinemachineCamera[] cams;
    public int activeIdx = 0;
    public int timeCamIdx = 0;

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

    public void SetGameSpeed(float timeScale)
    {
        Time.timeScale = timeScale;
        if (timeScale != 1.0f)
        {
            SetActiveCam(timeCamIdx);
        }
    }

    public void SetActiveCam(int index) {
        activeIdx = index;
        for (int i = 0; i < cams.Length; i++) {
            cams[i].Priority = (i == index ? 5000 : 0);
        }
    }

    public CinemachineCamera GetCamera(int index)
    {
        if (index >= cams.Length) { return null; }
        return cams[index];
    }
}
