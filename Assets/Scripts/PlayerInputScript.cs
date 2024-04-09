using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{

    private PlayerMovementScript playerMovementScript;
    private ShootingScript shootingScript;

    // Start is called before the first frame update
    void Start()
    {
        playerMovementScript = GetComponent<PlayerMovementScript>();
        shootingScript = GetComponent<ShootingScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        //is player trying to move
        if(HorizontalInput != 0.0f )
        {
            //move character in chosen direction
            playerMovementScript.HorizontalMovement(HorizontalInput);
        }

        //Does the player press the shoot button
        if (Input.GetButton("Fire1"))
        {
            //is the shooting script attached to allow player to shoot
            if (shootingScript != null)
            {
                //shoot
                shootingScript.Shoot();
            }

            else
            {
                Debug.Log("Attach shooting script!");
            }
        }
    }
}
