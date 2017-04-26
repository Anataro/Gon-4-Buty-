using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZdobywaniePunktów2 : MonoBehaviour {
	private GameManager4 gameManagerSkrypt;
	private SterowanieGracz2 sterowanieGracz2Skrypt;
	private int punkty2;
	public bool punktZdobyty = false;
	public Transform szklankaPK, kubekPK, kieliszekDoWinaPK, talerzPK, czajnikPK, szybaPK1, szybaPK2;

	void Start (){
		GameObject objekt = GameObject.Find ("GameManager");
		gameManagerSkrypt = objekt.GetComponent<GameManager4> ();

		GameObject objekt2 = GameObject.Find ("Gracz2TrybTrzeci");
		sterowanieGracz2Skrypt = objekt2.GetComponent<SterowanieGracz2> ();
	}

	IEnumerator Zatrzymywanie (){
		yield return new WaitForSeconds (0.5f);
		sterowanieGracz2Skrypt.poruszanie = false;
		sterowanieGracz2Skrypt.speed = 0.0f;
	}

	void OnCollisionEnter (Collision other){
		if (other.gameObject.name != "Wyskocznia" && other.gameObject.tag != "Szyba" && other.gameObject.name != "Szafka" && other.gameObject.tag != "Gracz1") {
			StartCoroutine (Zatrzymywanie());

			if (other.gameObject.tag == "Szklanka") {
				gameManagerSkrypt.punktyG2 += 10;
				punktZdobyty = true;
				Instantiate (szklankaPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Instantiate (szklankaPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Destroy (other.gameObject);
			}

			if (other.gameObject.tag == "Kubek") {
				gameManagerSkrypt.punktyG2 += 10;
				punktZdobyty = true;
				Instantiate (kubekPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Instantiate (kubekPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Destroy (other.gameObject);
			}

			if (other.gameObject.tag == "KieliszekDoWina") {
				gameManagerSkrypt.punktyG2 += 20;
				punktZdobyty = true;
				Instantiate (kieliszekDoWinaPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Instantiate (kieliszekDoWinaPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Destroy (other.gameObject);
			}

			if (other.gameObject.tag == "Talerz") {
				gameManagerSkrypt.punktyG2 += 15;
				punktZdobyty = true;
				Instantiate (talerzPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Destroy (other.gameObject);
			}

			if (other.gameObject.tag == "Czajnik") {
				gameManagerSkrypt.punktyG2 += 30;
				punktZdobyty = true;
				Instantiate (czajnikPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Destroy (other.gameObject);
			}
		}
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.name == "Szyba1") {
			Instantiate (szybaPK1, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
			Destroy (other.gameObject);
		}

		if (other.gameObject.name == "Szyba2") {
			Instantiate (szybaPK2, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
			Destroy (other.gameObject);
		}
	}
}
