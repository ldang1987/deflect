using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    [SerializeField] float bulletLife;

    private float dieTime;

	// Use this for initialization
	void Start () {
        dieTime = Time.time + bulletLife;
	}
	
	// Update is called once per frame
	void Update () {
        if(Time.time > dieTime)
        {
            Destroy(gameObject);
        }
    }
}
