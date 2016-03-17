using UnityEngine;
using System.Collections;

public class monster : MonoBehaviour {
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
			anim.SetBool ("walk", true);
			anim.SetBool ("jump", false);
			anim.SetBool ("idle", false);
		transform.position += new Vector3 (-0.02f, 0, 0);
	}
}
