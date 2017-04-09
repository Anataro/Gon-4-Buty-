using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZmianaKamery : MonoBehaviour {
	public Camera camG1, camG2, camWidok1, camWidok2;
	private SterowanieGracz1 sterowanieGracz1Skrypt;
	private SterowanieGracz2 sterowanieGracz2Skrypt;

	void Start () {
		GameObject objekt = GameObject.Find ("Gracz1TrybTrzeci");
		sterowanieGracz1Skrypt = objekt.GetComponent<SterowanieGracz1> ();

		GameObject objekt2 = GameObject.Find ("Gracz2TrybTrzeci");
		sterowanieGracz2Skrypt = objekt2.GetComponent<SterowanieGracz2> ();
	}
	
	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Gracz1") {
			sterowanieGracz1Skrypt.poruszanie = false;
			camG1.enabled = false;
			camWidok1.enabled = true;
		}

		if (other.gameObject.tag == "Gracz2") {
			sterowanieGracz2Skrypt.poruszanie = false;
			camG2.enabled = false;
			camWidok2.enabled = true;
		}
	}
}
