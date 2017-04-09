using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager3 : MonoBehaviour {
	public GUIText wyścigStart;
	public GUIText koniec;
	public GUIText punkty1, punkty2;

	public GameObject gracz1p;
	public GameObject gracz2p;

	private GameObject gracz1;
	private GameObject gracz2;

	public int punktyG1, punktyG2;

	void Awake()
	{
		gracz1 = GameObject.Find (gracz1p.name);
		gracz2 = GameObject.Find (gracz2p.name);
	}

	void Start(){
		StartCoroutine (Odliczanie ());
	}

	void Update () {
		if (Input.GetKey (KeyCode.R)) {
			SceneManager.LoadScene ("Trzeci Tryb");
		}
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}

		punkty1.text = "Punkty:" + punktyG1.ToString ();
		punkty2.text = "Punkty:" + punktyG2.ToString ();
	}


	IEnumerator Odliczanie(){
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
