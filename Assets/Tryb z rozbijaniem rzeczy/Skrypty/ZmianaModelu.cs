using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZmianaModelu : MonoBehaviour {
	public Transform szklankaPK, kubekPK, kieliszekDoWinaPK, talerzPK, czajnikPK;

	void OnCollisionEnter (Collision other){
			if (other.gameObject.tag == "Szklanka") {
				Instantiate (szklankaPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Instantiate (szklankaPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Destroy (other.gameObject);
			}

			if (other.gameObject.tag == "Kubek") {
				Instantiate (kubekPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Instantiate (kubekPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Destroy (other.gameObject);
			}

			if (other.gameObject.tag == "KieliszekDoWina") {
				Instantiate (kieliszekDoWinaPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Instantiate (kieliszekDoWinaPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Destroy (other.gameObject);
			}

			if (other.gameObject.tag == "Talerz") {
				Instantiate (talerzPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Instantiate (talerzPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Destroy (other.gameObject);
			}

			if (other.gameObject.tag == "Czajnik") {
				Instantiate (czajnikPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Instantiate (czajnikPK, new Vector3 (other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z), Quaternion.identity);
				Destroy (other.gameObject);
			}
		}
	}
