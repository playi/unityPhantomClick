using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scene2Controller : MonoBehaviour {

	public Button btn;
	public Text   txt;
	public Button doItAgain;

	// Use this for initialization
	void Start () {
		btn.onClick.AddListener(onClickBtn);
		
		doItAgain.onClick.AddListener(onClickDoItAgain);
		doItAgain.gameObject.SetActive(false);
	}
	
	void onClickBtn() {
		txt.text = "You Clicked It!";
		doItAgain.gameObject.SetActive(true);
	}
	
	void onClickDoItAgain() {
		Application.LoadLevel("main");
	}
}
