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

	void OnTriggerStay () {
		wf.SetActive (false);
		rota.SetActive (true);
	}
		
	void OnTriggerExit () {
		Debug.Log ("hoge");
		wf.SetActive (true);
		rota.SetActive (false);
	}
}
