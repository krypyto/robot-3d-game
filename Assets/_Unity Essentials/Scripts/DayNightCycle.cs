using UnityEngine;

/// <summary>
/// Rotates a Directional Light to simulate a full day/night cycle.
/// </summary>
public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Length of a full day in real-time seconds.")]
    [Min(1f)]
    public float dayDurationInSeconds = 120f;

    [Tooltip("Axis to rotate around (usually X for sun movement).")]
    public Vector3 rotationAxis = Vector3.right;

    private float rotationSpeed;

    private void Start()
    {
        // 360 degrees divided by total seconds = degrees per second
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    private void Update()
    {
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime, Space.World);
    }
}