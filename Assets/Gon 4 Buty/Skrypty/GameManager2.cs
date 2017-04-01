using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour {
	public GUIText wyścigStart;
	public GUIText koniec;


	public GameObject gracz1p;
	public GameObject gracz2p;

	private GameObject gracz1;
	private GameObject gracz2;

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
			SceneManager.LoadScene ("Gon 4 Buty");
		}
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}

		/*if(GameObject.Find ("LiniaMety").GetComponent<CzyKtosWygral> ().WygralGracz1 == true){
			koniec.text = "Wygrał gracz 1!";
			gracz1.GetComponent<SterowanieGracz1> ().start = false;
			gracz2.GetComponent<SterowanieGracz2> ().start = false;
		}
		if(GameObject.Find ("LiniaMety").GetComponent<CzyKtosWygral> ().WygralGracz2 == true){
			koniec.text = "Wygrał gracz 2!";
			gracz1.GetComponent<SterowanieGracz1> ().start = false;
			gracz2.GetComponent<SterowanieGracz2> ().start = false;
		}*/
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
