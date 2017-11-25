using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2D : MonoBehaviour
{
    public float step;


    GameObject player;


    

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    // Update is called once per frame
    void FixedUpdate () {

        this.transform.position = new Vector3(Vector2.Lerp(this.transform.position, player.transform.position, step * Time.deltaTime ).x, this.transform.position.y, -10);
		
	}


}
