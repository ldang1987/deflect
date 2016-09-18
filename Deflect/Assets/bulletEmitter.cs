using UnityEngine;
using System.Collections;

public class bulletEmitter : MonoBehaviour {

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float fireSpeed;

    private Vector3 bulletVelocity;

    // Use this for initialization
    void Start () {
        bulletVelocity.x = (-1) * fireSpeed;
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown("e"))
        {
            Vector3 tempRotation = new Vector3(0.0f, 0.0f, 90.0f);
            GameObject instance = Instantiate(bulletPrefab, this.transform.position, Quaternion.Euler(tempRotation)) as GameObject;
            instance.GetComponent<Rigidbody>().velocity = bulletVelocity;
        }
	}
}
