using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Counter : MonoBehaviour {
	public Text counter;
	public static int chickenLeft=10;
	private string displayedCounter="Poulets restants à trouver : ";

	// Use this for initialization
	void Start () {
		counter.text=displayedCounter + chickenLeft;
	}
	
	// Update is called once per frame
	void Update () {
		counter.text=displayedCounter + chickenLeft;

		if (chickenLeft <=0){
			Application.LoadLevel("GameOver");
		}
	}
}
