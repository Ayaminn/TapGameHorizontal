using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Select : MonoBehaviour {
	
	void Start () {
		Button button = this.GetComponent <Button> ();
		button.onClick.AddListener (() => {
			CallStage(button.tag);
		});
	}

	void CallStage(string i){
		if (i == "One") {
			Application.LoadLevel ("Stage1");
		}
	}
}