﻿using UnityEngine;
using System.Collections;

public class swordScript : MonoBehaviour {

    [SerializeField]
    private Rigidbody swordRigidbody;
    [SerializeField]
    private Vector3 oldpos;
    [SerializeField]
    private Vector3 newpos;
    [SerializeField]
    private Vector3 velocity;

	// Use this for initialization
	void Start () {
        swordRigidbody = gameObject.GetComponent<Rigidbody>();
        oldpos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        float flip = 1f;
        if(transform.rotation.eulerAngles.z < 180 && transform.rotation.eulerAngles.z > 0)
        {
            flip = -1f;
        }

        newpos = transform.position;
        //var media = (newpos - oldpos);
        Vector3 media = (newpos - oldpos);
        /*if (media.Equals(Vector3.zero))
        {
            velocity = media / Time.deltaTime;
        }*/

        velocity = media / Time.deltaTime;
        oldpos = newpos;
        newpos = transform.position;

        //flip* velocity.z * .015f + .01f

        Vector3 targetScale = new Vector3(.01f, flip * velocity.z * .015f + .01f, .01f);
        Vector3 newScale = Vector3.Lerp(transform.localScale, targetScale, .5f);

        transform.localScale = newScale;

        Debug.Log(transform.rotation.eulerAngles);
	}
}
