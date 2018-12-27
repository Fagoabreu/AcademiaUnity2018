using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movimento : MonoBehaviour {
    [SerializeField]
    private float movementSpeed = 5f;

    private Rigidbody2D myRigdbody;
    private float horizontal;
    private bool facingRight = true;
    

	// Use this for initialization
	void Start () {
        myRigdbody = gameObject.GetComponent<Rigidbody2D>();
        facingRight = true;
}
	
	// Update is called once per frame
	void Update () {
        horizontal = Input.GetAxis("Horizontal");
        
    }

    private void FixedUpdate()
    {
        HandMovement(horizontal);
        flip(horizontal);
    }


    void HandMovement(float horizontal)
    {
        myRigdbody.velocity = new Vector2(horizontal * movementSpeed, myRigdbody.velocity.y );
    }

    void flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal <0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
        
    }
}
