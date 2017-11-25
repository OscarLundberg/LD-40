using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int hp;
    public float speed;
    private int targetDir = -1;

    public void Damage()
    {
        hp--;
        if(hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }


    public void FixedUpdate()
    {
        Move();
    }


    public virtual void Move()
    {
        this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(targetDir * speed, 0));
        print("moving");
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag != "Player")
        {  
            targetDir = -targetDir;
        }
        else
        {
            collision.transform.GetComponent<CharController>().Hit();
        }
    }

}
