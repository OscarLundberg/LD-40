using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour {

    public Rigidbody2D rb;

    public float moveSpeed;
    public float jumpSpeed;

    public GameObject shot;

    private float timer;
    public float shotCooldown;
	
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
            if(rb.velocity.y == 0)
           { 
                rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed * Time.deltaTime));
           }
        }
    }


    private void Update()
    {
        timer += Time.deltaTime;

        
        if(Input.GetButtonDown("Fire1"))
        {
            if(ReadyToFire())
            {
                GameObject i = Instantiate(shot) as GameObject;
                i.transform.parent = this.transform;
                i.transform.position = this.transform.position;
                i.GetComponent<Projectile>().Fire();

                timer = 0;
            }

        }
    }

    private bool ReadyToFire()
    {
        if (timer > shotCooldown)
        {
            return true;
        }

        return false;
    }

}
