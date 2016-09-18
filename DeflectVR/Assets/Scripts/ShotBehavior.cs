using UnityEngine;
using System.Collections;

public class ShotBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * Time.deltaTime * 1000f;
	
	}
	// If shot collides with wall, it will destory itself.
	void OnCollisionEnter(Collision otherObj) {
		if (otherObj.gameObject.tag == "Wall") {
			GameObject.Destroy (gameObject, 0);
		}
	} 
}
