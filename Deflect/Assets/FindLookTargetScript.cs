using UnityEngine;
using System.Collections;

public class FindLookTargetScript : MonoBehaviour {

    [SerializeField] GameObject mainCamera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 direction = mainCamera.gameObject.transform.forward; //rotation.eulerAngles;
        //direction += new Vector3(0.0f, 90.0f, 0.0f);



        Debug.DrawRay(mainCamera.gameObject.transform.position, direction);
	}
}
