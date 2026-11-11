using UnityEngine;
using Unity.Cinemachine;
using Unity.Mathematics;

[RequireComponent (typeof(CinemachineCamera))]
public class ZoomCamera : MonoBehaviour
{
    public const float minZoom = 5;
    public const float maxZoom = 10;
    public float zoomSpeed = 1.0f;

    private CinemachineCamera cam;

    void Start()
    {
        cam = GetComponent<CinemachineCamera>();
    }

    void Update()
    {
        if (!cam.isActiveAndEnabled) { return; }
        float zoom = 0.0f;
        if (Input.GetKey(KeyCode.Q)) {
            zoom += zoomSpeed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.E)) {
            zoom -= zoomSpeed * Time.deltaTime;
        }
        cam.Lens.OrthographicSize = math.clamp(
            cam.Lens.OrthographicSize + zoom,
            minZoom,
            maxZoom
        );
    }
}
