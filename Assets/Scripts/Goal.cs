using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	public Camera came2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 0, -0.5f));
		if (came2.enabled){
			gameObject.SetActive (true);
		} else {
			gameObject.SetActive (false);
		}
	}

	void OnCollisionEnter (Collision col) {
		if (col.transform.tag == "Player") {
			Application.LoadLevel ("Goal");
		}
	}
}
