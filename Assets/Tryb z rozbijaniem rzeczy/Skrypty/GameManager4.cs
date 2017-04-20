using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager4 : MonoBehaviour {
	public GUIText wyścigStart;
	public GUIText koniec;
	public GUIText punkty1, punkty2;
	public GUIText następnaRunda;

	public GameObject gracz1p;
	public GameObject gracz2p;

	private GameObject gracz1;
	private GameObject gracz2;

	[HideInInspector]
	public int punktyG1, punktyG2;
	public int iloscRund;
	private int nrRundy = 1, ostatniaRunda;
	private bool koniecGry = false;

	private ZdobywaniePunktów1 zdobywaniePunktów1Skrypt;
	private ZdobywaniePunktów2 zdobywaniePunktów2Skrypt;
	private Respawn3 respawnSkrypt;
	private ZmianaKamery zmianaKamerySkrypt;
	private SterowanieGracz1 sterowanieGracz1Skrypt;
	private SterowanieGracz2 sterowanieGracz2Skrypt;

	void Awake () {
		gracz1 = gracz1p;
		gracz2 = gracz2p;

		ostatniaRunda = iloscRund;
	}

	void Start(){
		StartCoroutine (Odliczanie ());

		GameObject objekt = GameObject.Find ("Gracz1TrybTrzeci");
		zdobywaniePunktów1Skrypt = objekt.GetComponent<ZdobywaniePunktów1> ();

		GameObject objekt2 = GameObject.Find ("Gracz2TrybTrzeci");
		zdobywaniePunktów2Skrypt = objekt2.GetComponent<ZdobywaniePunktów2> ();

		GameObject objekt3 = GameObject.Find ("GameManager");
		respawnSkrypt = objekt3.GetComponent<Respawn3> ();

		GameObject objekt4 = GameObject.Find ("ZmieniaczKamery");
		zmianaKamerySkrypt = objekt4.GetComponent<ZmianaKamery> ();

		GameObject objekt5 = GameObject.Find ("Gracz1TrybTrzeci");
		sterowanieGracz1Skrypt = objekt5.GetComponent<SterowanieGracz1> ();

		GameObject objekt6 = GameObject.Find ("Gracz2TrybTrzeci");
		sterowanieGracz2Skrypt = objekt6.GetComponent<SterowanieGracz2> ();
	}

	void Update () {
		if (Input.GetKey (KeyCode.R)) {
			SceneManager.LoadScene ("Tryb z rozbijaniem rzeczy PK");
		}
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}

		if (nrRundy == ostatniaRunda)
			koniecGry = true;

		punkty1.text = "Punkty:" + punktyG1.ToString ();
		punkty2.text = "Punkty:" + punktyG2.ToString ();

		if (zdobywaniePunktów1Skrypt.punktZdobyty == true && zdobywaniePunktów2Skrypt.punktZdobyty == true && koniecGry == true)
			StartCoroutine (kończenieGry());

		if (zdobywaniePunktów1Skrypt.punktZdobyty == true && zdobywaniePunktów2Skrypt.punktZdobyty == true && koniecGry == false) {
			następnaRunda.text = "Wciśnij 'spację', aby rozpocząć następną rundę";
			if (Input.GetKeyDown (KeyCode.Space)) {
				nrRundy++;
				respawnSkrypt.Resp (gracz1, 1);
				respawnSkrypt.Resp (gracz2, 2);
				StartCoroutine (Odliczanie ());
				zmianaKamerySkrypt.camWidok1.enabled = false;
				zmianaKamerySkrypt.camWidok2.enabled = false;
				zmianaKamerySkrypt.camG1.enabled = true;
				zmianaKamerySkrypt.camG2.enabled = true;
				zdobywaniePunktów1Skrypt.punktZdobyty = false;
				zdobywaniePunktów2Skrypt.punktZdobyty = false;
				sterowanieGracz1Skrypt.poruszanie = true;
				sterowanieGracz2Skrypt.poruszanie = true;
				następnaRunda.text = "";
			}
		}
	}

	IEnumerator kończenieGry(){
		yield return new WaitForSeconds (3);

			if (punktyG1 > punktyG2)
				wyścigStart.text = "Wygrał gracz 1!";

			if (punktyG2 > punktyG1)
				wyścigStart.text = "Wygrał gracz 2!";

			if (punktyG1 == punktyG2)
				wyścigStart.text = "Remis!";
	}

	IEnumerator Odliczanie(){
		yield return new WaitForSeconds(1);
		if (nrRundy != ostatniaRunda) {
			wyścigStart.text = "Runda " + nrRundy.ToString ();
		} else {
			wyścigStart.text = "Ostatnia runda!";
		}
		yield return new WaitForSeconds(1);
		wyścigStart.text = "3";
		yield return new WaitForSeconds(1);
		wyścigStart.text = "2";
		yield return new WaitForSeconds(1);
		wyścigStart.text = "1";
		yield return new WaitForSeconds(1);
		wyścigStart.text = "START!";
		yield return new WaitForSeconds(0.5f);
		wyścigStart.text = "";
		gracz1.GetComponent<SterowanieGracz1> ().start = true;
		gracz2.GetComponent<SterowanieGracz2> ().start = true;

	}

}
