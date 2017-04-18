using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZdobywaniePunktów1 : MonoBehaviour {
	private GameManager4 gameManagerSkrypt;
	private SterowanieGracz1 sterowanieGracz1Skrypt;
	private int punkty1;
	public bool punktZdobyty = false;
	public Transform szklankaPK, kubekPK, kieliszekDoWinaPK, talerzPK, czajnikPK, szybaPK;

	void Start (){
		GameObject objekt = GameObject.Find ("GameManager");
		gameManagerSkrypt = objekt.GetComponent<GameManager4> ();

		GameObject objekt2 = GameObject.Find ("Gracz1TrybTrzeci");
		sterowanieGracz1Skrypt = objekt2.GetComponent<SterowanieGracz1> ();
	}

	IEnumerator Zatrzymywanie (){
		yield return new WaitForSeconds (0.5f);
		sterowanieGracz1Skrypt.poruszanie = false;
		sterowanieGracz1Skrypt.speed = 0.0f;
	}

	void OnCollisionEnter (Collision other){
		if (other.gameObject.name != "Wyskocznia" && other.gameObject.tag != "Szyba" && other.gameObject.name != "Szafka") {
			StartCoroutine (Zatrzymywanie());

			if (other.gameObject.tag == "Szklanka") {
				gameManagerSkrypt.punktyG1 += 10;
				punktZdobyty = true;
				Instantiate (szklankaPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Instantiate (szklankaPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Destroy (other.gameObject);
			}

			if (other.gameObject.tag == "Kubek") {
				gameManagerSkrypt.punktyG1 += 10;
				punktZdobyty = true;
				Instantiate (kubekPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Instantiate (kubekPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Destroy (other.gameObject);
			}

			if (other.gameObject.tag == "KieliszekDoWina") {
				gameManagerSkrypt.punktyG1 += 20;
				punktZdobyty = true;
					Instantiate (kieliszekDoWinaPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
					Instantiate (kieliszekDoWinaPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
					Destroy (other.gameObject);
			}

			if (other.gameObject.tag == "Talerz") {
				gameManagerSkrypt.punktyG1 += 15;
				punktZdobyty = true;
				Instantiate (talerzPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Destroy (other.gameObject);
			}

			if (other.gameObject.tag == "Czajnik") {
				gameManagerSkrypt.punktyG1 += 30;
				punktZdobyty = true;
				Instantiate (czajnikPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Instantiate (czajnikPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Destroy (other.gameObject);
			}
		}
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Szyba") {
			Instantiate (szybaPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
			Instantiate (szybaPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
			Destroy (other.gameObject);
		}
	}
}
