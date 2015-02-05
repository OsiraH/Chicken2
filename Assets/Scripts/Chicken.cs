using UnityEngine;
using System.Collections;

public class Chicken : MonoBehaviour {
	public int chickenDamage=1;
	private ParticleEmitter explosion;
	public float emissionTime = 3f;
	public float timeToDestroy = 0.3f;
	public AudioClip chickenSound;
	public AudioClip explosionSound;
	public AudioClip mmmmm;

	void Awake(){
		explosion = GetComponentInChildren<ParticleEmitter>();
	}

	void Update() {
		if (chickenDamage <= 0) { 
			Counter.chickenLeft--;
			explosion.emit = true;
			AudioSource.PlayClipAtPoint(chickenSound,transform.position);
			AudioSource.PlayClipAtPoint(explosionSound,transform.position);
			AudioSource.PlayClipAtPoint(mmmmm,transform.position);
			Destroy(gameObject,timeToDestroy);
			chickenDamage=1;
		}
	}
}
