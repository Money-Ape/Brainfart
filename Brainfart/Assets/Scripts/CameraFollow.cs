using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player; // My Player.
    public Vector3 offset = new Vector3(0, 5, -10); // Offset from the Player.
    public float smoothSpeed = 5f; // Smooth transition Speed.

    // Update is called once per frame
    void LateUpdate()
    {
        if (Player != null){
            Vector3 desiredPosition = Player.position + offset; // Calculate the desiredPosition.
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime); // Smoothly difference the desiredPosition & smoothSpped.1
            transform.LookAt(Player); // Position will at the Player.
        }

    }
}
