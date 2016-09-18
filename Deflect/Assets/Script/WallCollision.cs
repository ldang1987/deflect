using UnityEngine;
using System.Collections;

public class WallCollision : MonoBehaviour {

	public Score_PTS scoreBoard; 
	// private int count;
	// Use this for initialization
	void Start () {
		// count = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision otherObj) {
		if (otherObj.gameObject.tag == "Projectile") {
			// count += 1;
			// Debug.Log ("Score " + count);
			scoreBoard.increaseScoreCount();
		}
	}
}
