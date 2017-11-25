using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifeTime;
    public float speed;


    private void Start()
    {
        Destroy(this.gameObject, lifeTime);
    }


    public void Fire()
    {
        this.GetComponent<Rigidbody2D>().AddForce(transform.right * speed);
    }


	
}
