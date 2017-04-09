using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LicznikPunktów2 : MonoBehaviour {
	private GameManager3 gameManagerSkrypt;
	private SterowanieGracz2 sterowanieGracz2Skrypt;
	private int punkty2;
	public bool punktZdobyty = false;

	void Start (){
		GameObject objekt = GameObject.Find ("GameManager");
		gameManagerSkrypt = objekt.GetComponent<GameManager3> ();

		GameObject objekt2 = GameObject.Find ("Gracz2TrybTrzeci");
		sterowanieGracz2Skrypt = objekt2.GetComponent<SterowanieGracz2> ();
	}

	void OnCollisionEnter (Collision other){
		if (other.gameObject.name != "Wyskocznia") {
			sterowanieGracz2Skrypt.start = false;
			if (other.gameObject.name == "Torus1" && punktZdobyty == false) {
				gameManagerSkrypt.punktyG2 += 10;
				punktZdobyty = true;
			}

			if (other.gameObject.name == "Torus2" && punktZdobyty == false) {
				gameManagerSkrypt.punktyG2 += 20;
				punktZdobyty = true;
			}

			if (other.gameObject.name == "Torus3" && punktZdobyty == false) {
				gameManagerSkrypt.punktyG2 += 40;
				punktZdobyty = true;
			}

			if (other.gameObject.name == "Torus4" && punktZdobyty == false) {
				gameManagerSkrypt.punktyG2 += 60;
				punktZdobyty = true;
			}

			if (other.gameObject.name == "Torus5" && punktZdobyty == false) {
				gameManagerSkrypt.punktyG2 += 80;
				punktZdobyty = true;
			}

			if (other.gameObject.name == "Torus6" && punktZdobyty == false) {
				gameManagerSkrypt.punktyG2 += 100;
				punktZdobyty = true;
			}
		}
	}
}
