using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "chicken"){
			other.gameObject.GetComponent<Chicken>().chickenDamage--;
		}

	}


}