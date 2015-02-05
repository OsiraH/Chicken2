using UnityEngine;
using System.Collections;

public class RandomSpawn : MonoBehaviour {
	public GameObject chicken;
	public int nbChicken = 10;

	// Use this for initialization
	void Start () {

		for (int i=0; i<nbChicken; i++) {
			Vector3 position = new Vector3 (Random.Range (-22, 22), 2f, Random.Range (-22, 22));

			Instantiate (chicken, position, Quaternion.identity);
			gameObject.tag = "chicken";
		}
	}


}
