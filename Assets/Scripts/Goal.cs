using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	public Camera came2;

	private bool isMainColor = false;
	[SerializeField] Color color1 = Color.white, color2 = Color.white;
	[SerializeField] UnityEngine.UI.Image image = null;

	[SerializeField]
	CanvasGroup group = null;

	[SerializeField]
	Fade fade = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 0, -0.5f));
		if (came2.enabled==true){
			Debug.Log ("came");
			gameObject.SetActive (true);
		} else {
			//gameObject.SetActive (false);
		}
	}

	void OnCollisionEnter (Collision col) {
		if (col.transform.tag == "Player") {
			group.blocksRaycasts = false;
			fade.FadeIn (3, () =>
				{
					//image.color = (isMainColor) ? color1 : color2;
					isMainColor = !isMainColor;
					Application.LoadLevel ("Goal");
					fade.FadeOut(3, ()=>{
						
						group.blocksRaycasts = true;
					});
				});
		}
	}
}
