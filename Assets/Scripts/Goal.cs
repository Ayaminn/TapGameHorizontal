using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	public Camera came2;
	public GameObject my;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (came2.enabled){
			my.SetActive (true);
		} else {
			my.SetActive (false);
		}
	}

	void OnCollisionEnter (Collision col) {
		if (col.transform.tag == "Player") {
			Application.LoadLevel ("Goal");
		}
	}
}
