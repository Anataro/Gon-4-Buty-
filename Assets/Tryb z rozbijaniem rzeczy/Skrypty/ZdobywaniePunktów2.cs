using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZdobywaniePunktów2 : MonoBehaviour {
	private GameManager4 gameManagerSkrypt;
	private SterowanieGracz2 sterowanieGracz2Skrypt;
	private int punkty2;
	public bool punktZdobyty = false;

	void Start (){
		GameObject objekt = GameObject.Find ("GameManager");
		gameManagerSkrypt = objekt.GetComponent<GameManager4> ();

		GameObject objekt2 = GameObject.Find ("Gracz2TrybTrzeci");
		sterowanieGracz2Skrypt = objekt2.GetComponent<SterowanieGracz2> ();
	}

	void OnCollisionEnter (Collision other){
		if (other.gameObject.name != "Wyskocznia") {
			sterowanieGracz2Skrypt.start = false;

			if (other.gameObject.tag == "Szklanka" && other.gameObject.GetComponent<Rigidbody>().isKinematic == true) {
				gameManagerSkrypt.punktyG2 += 10;
				punktZdobyty = true;
				other.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			}

			if (other.gameObject.tag == "Kubek" && other.gameObject.GetComponent<Rigidbody>().isKinematic == true) {
				gameManagerSkrypt.punktyG2 += 10;
				punktZdobyty = true;
				other.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			}

			if (other.gameObject.tag == "KieliszekDoWina" && other.gameObject.GetComponent<Rigidbody>().isKinematic == true) {
				gameManagerSkrypt.punktyG2 += 20;
				punktZdobyty = true;
				other.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			}

			if (other.gameObject.tag == "Talerz" && other.gameObject.GetComponent<Rigidbody>().isKinematic == true) {
				gameManagerSkrypt.punktyG2 += 15;
				punktZdobyty = true;
				other.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			}

			if (other.gameObject.tag == "Czajnik" && other.gameObject.GetComponent<Rigidbody>().isKinematic == true) {
				gameManagerSkrypt.punktyG2 += 30;
				punktZdobyty = true;
				other.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			}
		}
	}
}
