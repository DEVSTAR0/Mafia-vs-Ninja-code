using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject groundChecker;
    public LayerMask whatIsGround;

    public float maxSpeed = 5.0f;
    bool isOnGround = false;

    //Create a referance to the Rigidbody2D so we can manipulate it
    Rigidbody2D  playerObject;

    // Start is called before the first frame update
    void Start()
    {
     //Find the Rigidbody2D component that is attatched to the same object as this script
     playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Create a 'float' that will be equal to the players horizontal input 
        float movementValueX = Input.GetAxis("Horizontal");

        //Change the x velocity of the Rigidbody2D to be equal to the movement value
        playerObject.velocity = new Vector2 (movementValueX*100, playerObject.velocity.y);

        //Check to see if the ground check object is touching the ground
        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1.0f, whatIsGround);
    }
        
}

public class PhysicsJump : MonoBehaviour
{
    [SerializeField] float jumpForce = 10;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}