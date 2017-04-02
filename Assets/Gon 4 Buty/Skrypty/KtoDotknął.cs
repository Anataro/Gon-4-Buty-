using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KtoDotknął : MonoBehaviour {
	public bool dotknąłGracz1, dotknąłGracz2;
	private NaliczaniePunktów naliczaniePunktówSkrypt;
	public int numerek;

	void Start (){
		GameObject objekt = GameObject.Find ("GameManager");
		naliczaniePunktówSkrypt = objekt.GetComponent<NaliczaniePunktów> ();

	}

	void OnCollisionEnter (Collision other){
		if (other.gameObject.tag == "Gracz1") {
			dotknąłGracz1 = true;
			dotknąłGracz2 = false;
		}

		if (other.gameObject.tag == "Gracz2") {
			dotknąłGracz1 = false;
			dotknąłGracz2 = true;;
		}


		if (other.gameObject.tag == "Respawner") {
			if (dotknąłGracz1 == true) {
				naliczaniePunktówSkrypt.punkty1 = naliczaniePunktówSkrypt.punkty1 + 1;
				Destroy (gameObject);
			}

			if (dotknąłGracz2 == true) {
				naliczaniePunktówSkrypt.punkty2 = naliczaniePunktówSkrypt.punkty2 + 1;
				Destroy (gameObject);
			}

		}
	}
}
