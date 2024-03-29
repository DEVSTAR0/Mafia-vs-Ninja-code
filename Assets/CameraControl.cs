using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //Create a public reference to the player - we will assign this using the unity editor 
    public GameObject player;

    private void FixedUpdate()
    {
        //Change our position relative to the player position
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
} 