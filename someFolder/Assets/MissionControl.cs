using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionControl : MonoBehaviour {

	public Text mission1Text;
	public Text mission2Text;
	public Text mission3Text;

	public Button acceptMission1;
	public Button acceptMission2;
	public Button acceptMission3;

	// Use this for initialization
	void Start () {
		acceptMission1.onClick.AddListener(GoToM1);
		acceptMission2.onClick.AddListener(GoToM2);
		acceptMission3.onClick.AddListener(GoToM3);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GoToM1() {
		//Goto Mission 1
		print("Going to mission 1");
	}

	void GoToM2() {
		//Goto Mission 2
		print("Going to mission 2");
	}

	void GoToM3() {
		//Goto Mission 3
		print("Going to mission 3");
	}
}
