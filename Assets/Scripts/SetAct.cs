using UnityEngine;
using System.Collections;

public class SetAct: MonoBehaviour {
	public GameObject wf;
	public GameObject rota;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter () {
		wf.SetActive (false);
		rota.SetActive (true);
	}
		
	void OnTrigerExit () {
		wf.SetActive (true);
		rota.SetActive (true);
	}
}
