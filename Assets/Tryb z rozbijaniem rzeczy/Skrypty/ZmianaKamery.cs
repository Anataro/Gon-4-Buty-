using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZmianaKamery : MonoBehaviour {
	public Camera camG1, camG2, camWidok1, camWidok2;
	private SterowanieGracz1 sterowanieGracz1Skrypt;
	private SterowanieGracz2 sterowanieGracz2Skrypt;
	public bool spowalnianieG1 = false, spowalnianieG2 = false;

	void Start () {
		GameObject objekt = GameObject.Find ("Gracz1TrybTrzeci");
		sterowanieGracz1Skrypt = objekt.GetComponent<SterowanieGracz1> ();

		GameObject objekt2 = GameObject.Find ("Gracz2TrybTrzeci");
		sterowanieGracz2Skrypt = objekt2.GetComponent<SterowanieGracz2> ();
	}

	void Update(){
		if (spowalnianieG1 == true && sterowanieGracz1Skrypt.speed > 35.0f)
			sterowanieGracz1Skrypt.speed -= 0.1f;

		if (spowalnianieG2 == true && sterowanieGracz2Skrypt.speed > 35.0f)
			sterowanieGracz2Skrypt.speed -= 0.1f;
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Gracz1") {
			sterowanieGracz1Skrypt.poruszanie = false;
			camG1.enabled = false;
			camWidok1.enabled = true;
			spowalnianieG1 = true;
		}

		if (other.gameObject.tag == "Gracz2") {
			sterowanieGracz2Skrypt.poruszanie = false;
			sterowanieGracz2Skrypt.speed -= 0.5f;
			camG2.enabled = false;
			camWidok2.enabled = true;
			spowalnianieG2 = true;
		}
	}
}
