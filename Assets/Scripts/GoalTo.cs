using UnityEngine;
using System.Collections;

public class GoalTo : MonoBehaviour {

	private bool isMainColor = false;
	[SerializeField] Color color1 = Color.white, color2 = Color.white;
	[SerializeField] UnityEngine.UI.Image image = null;

	[SerializeField]
	CanvasGroup group = null;

	[SerializeField]
	Fade fade = null;

	public void TapTo () {
		fade.FadeIn (3, () =>
			{
				//image.color = (isMainColor) ? color1 : color2;
				isMainColor = !isMainColor;
				Application.LoadLevel ("Select");
				fade.FadeOut(3, ()=>{

					group.blocksRaycasts = true;
				});
			});
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			//TapTo ();
		}
	
	}
}
