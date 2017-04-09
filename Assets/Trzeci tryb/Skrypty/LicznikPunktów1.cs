using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LicznikPunktów1 : MonoBehaviour {
	private GameManager3 gameManagerSkrypt;
	private SterowanieGracz1 sterowanieGracz1Skrypt;
	private int punkty1;
	public bool punktZdobyty = false;

	void Start (){
		GameObject objekt = GameObject.Find ("GameManager");
		gameManagerSkrypt = objekt.GetComponent<GameManager3> ();

		GameObject objekt2 = GameObject.Find ("Gracz1TrybTrzeci");
		sterowanieGracz1Skrypt = objekt2.GetComponent<SterowanieGracz1> ();
	}

	void OnCollisionEnter (Collision other){
		if (other.gameObject.name != "Wyskocznia") {
			sterowanieGracz1Skrypt.start = false;
			if (other.gameObject.name == "Torus1" && punktZdobyty == false) {
				gameManagerSkrypt.punktyG1 += 10;
				punktZdobyty = true;
			}

			if (other.gameObject.name == "Torus2" && punktZdobyty == false) {
				gameManagerSkrypt.punktyG1 += 20;
				punktZdobyty = true;
			}

			if (other.gameObject.name == "Torus3" && punktZdobyty == false) {
				gameManagerSkrypt.punktyG1 += 40;
				punktZdobyty = true;
			}

			if (other.gameObject.name == "Torus4" && punktZdobyty == false) {
				gameManagerSkrypt.punktyG1 += 60;
				punktZdobyty = true;
			}

			if (other.gameObject.name == "Torus5" && punktZdobyty == false) {
				gameManagerSkrypt.punktyG1 += 80;
				punktZdobyty = true;
			}

			if (other.gameObject.name == "Torus6" && punktZdobyty == false) {
				gameManagerSkrypt.punktyG1 += 100;
				punktZdobyty = true;
			}
		}
	}
}
