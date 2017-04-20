using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn3 : MonoBehaviour {

	public GameObject gracz1p;
	public GameObject gracz2p;

	private GameObject gracz1;
	private GameObject gracz2;

	public float gracz1X, gracz1Y, gracz1Z, gracz2X, gracz2Y, gracz2Z;

	void Awake () {
		gracz1 = gracz1p;
		gracz2 = gracz2p;
	}

	public void Resp(GameObject gracz, int n)
	{
		if (n == 1) 
		{
			gracz1.GetComponent<SterowanieGracz1> ().speed = 0.0f;
			gracz1.transform.rotation = new Quaternion (0, -90, 0, 90);
			gracz1.transform.position = new Vector3 (gracz1X, gracz1Y, gracz1Z);

		}
		if (n == 2)
		{
			gracz2.GetComponent<SterowanieGracz2> ().speed = 0.0f;
			gracz2.transform.position = new Vector3 (gracz2X, gracz2Y, gracz2Z);
			gracz2.transform.rotation = new Quaternion (0, -90, 0, 90);
		}

	}
}




