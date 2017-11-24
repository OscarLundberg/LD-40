using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrollText : MonoBehaviour {
	
	private Text text;
	public float textScrollSpeed = 50f;
	private string moveDir = "right";

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		/*if(moveDir == "right")
			text.transform.position += new Vector3(1, 0f, 0f) * textScrollSpeed * Time.deltaTime;
		else
			text.transform.position -= new Vector3(1, 0f, 0f) * textScrollSpeed * Time.deltaTime;

		if(text.transform.localPosition.x > -220f) {
			moveDir = "right";
			print("move Right");
		}
		else if(text.transform.localPosition.x < 220f){
			moveDir = "left";
			print("move left");
		}
*/
		
	}
}
