using UnityEngine;
using System.Collections;

public class CharacterMain : MonoBehaviour {

	public Rigidbody rb;
	public float jump;
	Camera _2DCamera;
	Camera right3DCamera;
	Camera left3DCamera;
	public bool leftCamera3D = false;
	public bool rightCamera3D = false;
	public bool camera2D = true;
	public bool onGround = false;
	Coll coll;

	// Use this for initialization
	void Start () {
		//coll = transform.findchild ("On").GetComponent<Coll> ().nowOn;

		rb = GetComponent<Rigidbody> ();

		_2DCamera = GameObject.Find("2D Camera").GetComponent<Camera>();
		right3DCamera = GameObject.Find ("3D Camera Right").GetComponent<Camera> ();
		left3DCamera = GameObject.Find ("3D Camera Left").GetComponent<Camera> ();
		right3DCamera.enabled = false;
		left3DCamera.enabled = false;
	}

	void OnCollisionEnter(Collision col){
		onGround = true;
	}

	void OnCollisionExit(Collision col){
		onGround = false;
	}
	
	// Update is called once per frame
	void Update () {
		//ゲームオーバー
		if (transform.position.y < 0){
			
		}

		//カメラの追従
		if (5 < transform.position.y){
			_2DCamera.transform.position = new Vector3 (transform.position.x + 5, transform.position.y, -7.5f);
		} else {
			_2DCamera.transform.position = new Vector3 (transform.position.x + 5, _2DCamera.transform.position.y, -7.5f);
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			//カメラ切り替え
			if (_2DCamera.enabled) {
				_2DCamera.enabled = false;
				right3DCamera.enabled = true;
				right3DCamera.transform.eulerAngles = new Vector3 (0, 90, 0);
				rightCamera3D = true;
				leftCamera3D = false;
				camera2D = false;
			} else {
				_2DCamera.enabled = true;
				right3DCamera.enabled = false;
				rightCamera3D = false;
				leftCamera3D = false;
				camera2D = true;
			}
		} else if (Input.GetKeyDown (KeyCode.S)) {
			if (_2DCamera.enabled) {
				_2DCamera.enabled = false;
				left3DCamera.enabled = true;
				left3DCamera.transform.eulerAngles = new Vector3 (0, -90, 0);
				rightCamera3D = false;
				leftCamera3D = true;
				camera2D = false;

			} else {
				_2DCamera.enabled = true;
				left3DCamera.enabled = false;
				rightCamera3D = false;
				leftCamera3D = false;
				camera2D = true;
			}
		}

		if (Input.GetKey(KeyCode.RightArrow)) {
			if (camera2D == true){
				transform.position += new Vector3 (0.05f, 0, 0);
			} else if (rightCamera3D == true) {
				transform.position += new Vector3 (0, 0, -0.05f);
			} else {
				transform.position += new Vector3 (0, 0, 0.05f);
			}

		} else if (Input.GetKey(KeyCode.LeftArrow)) {
			if (camera2D == true){
				transform.position += new Vector3 (-0.05f, 0, 0);
			} else if (rightCamera3D == true) {
				transform.position += new Vector3 (0, 0, 0.05f);
			} else {
				transform.position += new Vector3 (0, 0, -0.05f);
			}

		} else if (Input.GetKeyDown(KeyCode.Space) && onGround) {
			//ジャンプ
			if(rb.velocity.y < 0.2f) {
				rb.AddForce(transform.up * jump);
			}

		} else if (Input.GetKey(KeyCode.UpArrow) && camera2D == false) {
			if (rightCamera3D == true) {
				transform.position += new Vector3 (0.05f, 0, 0);
			} else {
				transform.position += new Vector3 (-0.05f, 0, 0);
			}

		} else if (Input.GetKey(KeyCode.DownArrow) && camera2D == false) {
			if (rightCamera3D == true) {
				transform.position += new Vector3 (-0.05f, 0, 0);
			} else {
				transform.position += new Vector3 (0.05f, 0, 0);
			}
		}
	}
}
