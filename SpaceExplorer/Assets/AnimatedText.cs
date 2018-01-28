using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatedText : MonoBehaviour {

	public string sentence;
	private string t;
	public Text texto;
	void Start () {
		StartCoroutine(TypeSentence(sentence));
	}
	IEnumerator TypeSentence (string sentence){
		t = "";
		foreach (char letter in sentence.ToCharArray()){
			t += letter;
			yield return new WaitForSeconds(0.01f);
		}
	}

	void Update (){
		texto.text = t;
	}
}
