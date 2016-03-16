using UnityEngine;
using System.Collections;

public class Five : MonoBehaviour {
	Renderer renderer;
	public Camera _2DCamera;
	public Camera right3DCamera;
	public Camera left3DCamera;

	// Use this for initialization
	void Start () {
		renderer = GetComponent<Renderer> ();
		renderer.enabled = false;
//		_2DCamera = GameObject.Find("2D Camera").GetComponent<Camera>();
//		right3DCamera = GameObject.Find ("3D Camera Right").GetComponent<Camera> ();
//		left3DCamera = GameObject.Find ("3D Camera Left").GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (_2DCamera.enabled == true) {
			renderer.enabled = false;
		} else {
			renderer.enabled = true;
		}
	}
}
