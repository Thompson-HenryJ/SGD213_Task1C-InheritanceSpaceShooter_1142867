using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineBase : MonoBehaviour
{
    [SerializeField]
    private float acceleration = 5000f;

    private Rigidbody2D ourRigidBody;


    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Accelerate(Vector2 direction)
    {

        Vector2 forceToAdd = direction * acceleration * Time.deltaTime;
        // apply forceToAdd to ourRigidbody
        ourRigidBody.AddForce(forceToAdd);
    }


}
