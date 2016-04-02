using UnityEngine;
using System.Collections;

public class CharacterMain : MonoBehaviour {

	public Rigidbody rb;
	public float jump;
	Camera _2DCamera;
	public Camera right3DCamera;
	public Camera left3DCamera;
	public bool leftCamera3Df = false;
	public bool rightCamera3Df = false;
	public bool camera2D = true;
	public bool onGround = false;
	Coll coll;
	private Animator anim;
	public GameObject chars;
	public Animation anima;

	// Use this for initialization
	void Start () {
		//coll = transform.findchild ("On").GetComponent<Coll> ().nowOn;
		anim = chars.GetComponent<Animator>();

		rb = GetComponent<Rigidbody> ();

		_2DCamera = GameObject.Find("2D Camera").GetComponent<Camera>();
//		right3DCamera = GameObject.Find ("3D Camera Right").GetComponent<Camera> ();
//		left3DCamera = GameObject.Find ("3D Camera Left").GetComponent<Camera> ();
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
		if (transform.position.y < -0.5f){
			transform.position = new Vector3 (-7.0f, 1.1f, -0.3f);
		}

		//カメラの追従
		if (4f < transform.position.y){
			_2DCamera.transform.position = new Vector3 (_2DCamera.transform.position.x, chars.transform.position.y + 1, -17.4f);
		} else {
			_2DCamera.transform.position = new Vector3 (_2DCamera.transform.position.x, 4.97f, -17.4f);
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			//カメラ切り替え
			if (_2DCamera.enabled) {
				_2DCamera.enabled = false;
				right3DCamera.enabled = true;
				Debug.Log ("A");
				Debug.Log (right3DCamera.enabled);
				right3DCamera.transform.eulerAngles = new Vector3 (0, 90, 0);
				rightCamera3Df = true;
				leftCamera3Df = false;
				camera2D = false;
			} else {
				_2DCamera.enabled = true;
				right3DCamera.enabled = false;
				rightCamera3Df = false;
				leftCamera3Df = false;
				camera2D = true;
			}
		} else if (Input.GetKeyDown (KeyCode.S)) {
			if (_2DCamera.enabled) {
				_2DCamera.enabled = false;
				left3DCamera.enabled = true;
				left3DCamera.transform.eulerAngles = new Vector3 (0, -90, 0);
				rightCamera3Df = false;
				leftCamera3Df = true;
				camera2D = false;

			} else {
				_2DCamera.enabled = true;
				left3DCamera.enabled = false;
				rightCamera3Df = false;
				leftCamera3Df = false;
				camera2D = true;
			}
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			anim.SetBool ("walk", true);
			anim.SetBool ("jump", false);
			anim.SetBool ("idle", false);
			if (camera2D == true) {
				transform.position += new Vector3 (0.12f, 0, 0);
			} else if (rightCamera3Df == true) {
				transform.position += new Vector3 (0, 0, -0.12f);
			} else {
				transform.position += new Vector3 (0, 0, 0.12f);
			}

		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			anim.SetBool ("walk", true);
			anim.SetBool ("jump", false);
			anim.SetBool ("idle", false);
			if (camera2D == true) {
				transform.position += new Vector3 (-0.12f, 0, 0);
			} else if (rightCamera3Df == true) {
				transform.position += new Vector3 (0, 0, 0.12f);
			} else {
				transform.position += new Vector3 (0, 0, -0.12f);
			}

		} else if (Input.GetKeyDown (KeyCode.Space) && onGround) {
			//ジャンプ
			if (rb.velocity.y < 0.2f) {
				anim.SetBool ("walk", false);
				anim.Play("A_jump", 0, 0.0f);
				anim.SetBool ("idle", false);
				rb.AddForce (transform.up * jump);
			}

		} else if (Input.GetKey (KeyCode.UpArrow) && camera2D == false) {
			anim.SetBool ("walk", true);
			anim.SetBool ("jump", false);
			anim.SetBool ("idle", false);
			if (rightCamera3Df == true) {
				transform.position += new Vector3 (0.12f, 0, 0);
			} else {
				transform.position += new Vector3 (-0.12f, 0, 0);
			}

		} else if (Input.GetKey (KeyCode.DownArrow) && camera2D == false) {
			anim.SetBool ("walk", true);
			anim.SetBool ("jump", false);
			anim.SetBool ("idle", false);
			if (rightCamera3Df == true) {
				transform.position += new Vector3 (-0.12f, 0, 0);
			} else {
				transform.position += new Vector3 (0.12f, 0, 0);
			}
		} else {
			anim.SetBool ("walk", false);
//			anim.SetBool ("jump", false);
//			anim.SetBool ("idle", true);
		}
	}
}
