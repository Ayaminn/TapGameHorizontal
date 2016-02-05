using UnityEngine;
using System.Collections;

public class Activity : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 31; i++){
			if (i % 3 == 0 && i != 0){
				Debug.Log ("3の倍数");
			} else {
				Debug.Log (i);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
