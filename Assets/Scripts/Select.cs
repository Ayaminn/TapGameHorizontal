using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour {

	public void CallStage () {
		if (tag == "One") {
			Application.LoadLevel ("Stage1");
		}
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
