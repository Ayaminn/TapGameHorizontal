using UnityEngine;
using System.Collections;

public class Stop : MonoBehaviour {
	public GameObject mon;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter () {
		mon.SetActive (false);
	}
}
