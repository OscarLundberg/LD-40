﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour {

    public Rigidbody2D rb;

    public float moveSpeed;
    public float jumpSpeed;

	
	// Update is called once per frame
	void FixedUpdate ()
    {

        if(Input.GetAxis("Horizontal") > 0)
        {
            rb.AddForce(new Vector2(moveSpeed * Time.deltaTime, rb.velocity.y));

        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            rb.AddForce(new Vector2(-moveSpeed * Time.deltaTime, rb.velocity.y));
        }

        if(Input.GetAxis("Vertical") > 0)
        {
            //Jump

            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed * Time.deltaTime));
        }


    }


}
