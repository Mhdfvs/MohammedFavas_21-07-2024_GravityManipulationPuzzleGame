using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
//{
//    public Transform player;
//    public Vector3 offset;
//    void Start()
//    {
//        offset = transform.position - player.position;
//    }
//    void LateUpdate()
//    {
//        transform.position = player.position + offset;
//        transform.LookAt(player);
//    }
//}
{
    public Transform target; // The player character to follow
    public Vector3 offset;   // Offset from the target
    public float smoothSpeed = 0.125f; // Smooth speed for camera movement

    private void LateUpdate()
    {
        // Calculate the desired position based on the target position and offset
        Vector3 desiredPosition = target.position + offset;

        // Smoothly interpolate between the current position and the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Update the camera position
        transform.position = smoothedPosition;

        // Make the camera look at the target
        transform.LookAt(target);
    }
}
