using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HPScript : MonoBehaviour {
    public Text HPText;
	string plusMinus = "";

	public void SetText(int hpval){
		if (hpval > 0) {
			HPText.color = Color.green;
			plusMinus = "+";
		} else if (hpval < 0) {
			HPText.color = Color.red;
			plusMinus = "";
		} else {
			HPText.color = Color.cyan;
			plusMinus = "";
		}

		HPText.text = plusMinus + hpval.ToString() + " HP";
	}

	public void Destroy(){
		HPText.CrossFadeAlpha(0f, .5f, false);
		Destroy (gameObject, .5f);
	}
}
