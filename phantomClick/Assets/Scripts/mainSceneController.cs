using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mainSceneController : MonoBehaviour {

	public Button btn;
	public Text   txt;
	
	private       float btnClickedTime = 0;
	private const float countdownSecs  = 4;
	

	// Use this for initialization
	void Start () {
		btn.onClick.AddListener(onClickBtn);
	}
	
	// Update is called once per frame
	void Update () {
		if (btnClickedTime == 0) {
			return;
		}
		
		float t = countdownSecs - (Time.time - btnClickedTime);
		if (t > 0) {
			txt.text = "press-and-hold here!\n" + t.ToString("0.0") + "..";
		}
		else {
			gameObject.SetActive(false);
			Application.LoadLevel("scene2");
		}
	}
	
	void onClickBtn() {
		btnClickedTime = Time.time;
	}
}
