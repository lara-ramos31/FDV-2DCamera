using Unity.Mathematics;
using UnityEngine;

public class BackAndForthObject : MonoBehaviour
{
    public float speedX = 1.0f;
    public float offX = 10f;
    public float speedY = 1.0f;
    public float offY = 10f;

    private Vector2 pivot;
    private float phaseX = 0.0f;
    private float phaseY = 0.0f;

    void Start()
    {
        pivot = transform.position;
    }

    void Update()
    {
        phaseX += Time.deltaTime * speedX;
        phaseY += Time.deltaTime * speedY;
        Vector2 offset = new(
            offX * math.cos(phaseX), 
            offY * math.sin(phaseY)
        );
        transform.position = pivot + offset;
    }
}
