using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EngineBase : MonoBehaviour
{
    [SerializeField]
    private float acceleration = 5000f;

    private Rigidbody2D ourRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        //Populate ourRigidbody
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Accelerate(Vector2 direction)
    {
       /** if (direction.magnitude != 0)
        {
            //calculate our force to add
            Vector2 forceToAdd = direction * acceleration * Time.deltaTime;
            // apply forceToAdd to ourRigidbody
            ourRigidbody.AddForce(forceToAdd);
        }
        else
        {**/
            //calculate our force to add
            Vector2 forceToAdd = direction * acceleration * Time.deltaTime;
            // apply forceToAdd to ourRigidbody
            ourRigidbody.AddForce(forceToAdd);
        
    }


}
