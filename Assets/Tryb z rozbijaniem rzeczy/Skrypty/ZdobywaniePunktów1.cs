using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZdobywaniePunktów1 : MonoBehaviour {
	private GameManager4 gameManagerSkrypt;
	private SterowanieGracz1 sterowanieGracz1Skrypt;
	private int punkty1;
	public bool punktZdobyty = false;

	void Start (){
		GameObject objekt = GameObject.Find ("GameManager");
		gameManagerSkrypt = objekt.GetComponent<GameManager4> ();

		GameObject objekt2 = GameObject.Find ("Gracz1TrybTrzeci");
		sterowanieGracz1Skrypt = objekt2.GetComponent<SterowanieGracz1> ();
	}

	void OnCollisionEnter (Collision other){
		if (other.gameObject.name != "Wyskocznia") {
			sterowanieGracz1Skrypt.start = false;

			if (other.gameObject.tag == "Szklanka" && other.gameObject.GetComponentInChildren<Rigidbody>().isKinematic == true) {
				gameManagerSkrypt.punktyG1 += 10;
				punktZdobyty = true;
				other.gameObject.GetComponentInChildren<Rigidbody> ().isKinematic = false;
			}

			if (other.gameObject.tag == "Kubek" && other.gameObject.GetComponent<Rigidbody>().isKinematic == true) {
				gameManagerSkrypt.punktyG1 += 10;
				punktZdobyty = true;
				other.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			}

			if (other.gameObject.tag == "KieliszekDoWina"  && other.gameObject.GetComponentInChildren<Rigidbody> ().isKinematic == true) {
				Debug.Log ("dziala");
				gameManagerSkrypt.punktyG1 += 20;
				punktZdobyty = true;
				other.gameObject.GetComponentInChildren<Rigidbody> ().isKinematic = false;
			}

			if (other.gameObject.tag == "Talerz" && other.gameObject.GetComponent<Rigidbody>().isKinematic == true) {
				gameManagerSkrypt.punktyG1 += 15;
				punktZdobyty = true;
				other.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			}

			if (other.gameObject.tag == "Czajnik" && other.gameObject.GetComponent<Rigidbody>().isKinematic == true) {
				gameManagerSkrypt.punktyG1 += 30;
				punktZdobyty = true;
				other.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			}
		}
	}
}
