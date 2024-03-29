using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour 
{
    
    // Speed indicates how fast we accelerate Horizontally
   
    public float Speed = 5000f;

    private Rigidbody2D Rigidbody;

    public Vector2 HorizontalInput { get; private set; }

    // Use this for initialization
    void Start() 
    {
        // Get RigidbodyComponent once at the start of the game and store a reference to it
        Rigidbody = GetComponent<Rigidbody2D>(); 
    }

    //public announcement of movement action as used by the PlayerInputScript
    public void HorizontalMovement (float HorizontalInput)
    {
        Vector2 ForceToAdd = Vector2.right * HorizontalInput * Speed * Time.deltaTime;
        Rigidbody.AddForce(ForceToAdd);
    }

}
