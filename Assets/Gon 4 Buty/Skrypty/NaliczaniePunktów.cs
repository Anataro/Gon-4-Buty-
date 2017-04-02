using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaliczaniePunktów : MonoBehaviour {
	public GUIText iloscPunktow1, iloscPunktow2;
	public int punkty1, punkty2;
	private KtoDotknął ktoDotknąłSkrypt;

	private int numerowanie = 1;

	void Start (){
		punkty1 = 0;
		punkty2 = 0;

		/*GameObject[] przedmioty = GameObject.FindGameObjectsWithTag ("Przedmiot");
		foreach (GameObject przedmiot in przedmioty) {
			GetComponent<KtoDotknął> ().numerek = numerowanie;
			numerowanie++;
		}*/
	}

	void Update (){
		iloscPunktow1.text = "Punkty: " + punkty1.ToString ();
		iloscPunktow2.text = "Punkty: " + punkty2.ToString ();
	}
}
