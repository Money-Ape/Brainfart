using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb_ob;
    // Use this for Initialization.
    // void Start()
    // {
    //     Debug.Log("Player is online...");
        

    // }

    // Update is called once per frame.
    void FixedUpdate()
    {
        Debug.Log("Player is online...");
        rb_ob.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
