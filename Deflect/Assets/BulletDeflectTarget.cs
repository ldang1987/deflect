using UnityEngine;
using System.Collections;

public class BulletDeflectTarget : MonoBehaviour {

    public GameObject testTransform;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public Transform findDeflectTarget()
    {
        //Transform output = new Transform();

        Transform output = testTransform.transform;

        return output;
    }
}
