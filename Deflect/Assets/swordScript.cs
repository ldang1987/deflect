using UnityEngine;
using System.Collections;

public class swordScript : MonoBehaviour {

    Rigidbody swordRigidbody;
    Vector3 oldpos;
    Vector3 newpos;
    Vector3 velocity;

	// Use this for initialization
	void Start () {
        swordRigidbody = gameObject.GetComponent<Rigidbody>();
        oldpos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        float flip = 1;
        if(transform.rotation.eulerAngles.z < 180 && transform.rotation.eulerAngles.z > 0)
        {
            flip = -1;
        }

        newpos = transform.position;
        var media = (newpos - oldpos);
        velocity = media / Time.deltaTime;
        oldpos = newpos;
        newpos = transform.position;



        Vector3 targetScale = new Vector3(.01f, flip * velocity.z * .015f + .01f, .01f);
        Vector3 newScale = Vector3.Lerp(transform.localScale, targetScale, .5f);

        transform.localScale = newScale;

        Debug.Log(transform.rotation.eulerAngles);
	}
}
