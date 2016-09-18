using UnityEngine;
using System.Collections;

public class LagBehind : MonoBehaviour {

    [SerializeField]
    private GameObject other;
    [SerializeField]
    private float delay = .03f;
    [SerializeField]
    private float swordSize = 1.5f;
    [SerializeField]
    private float transparantRate = 0.1f;

    private float time;
    //private Rigidbody otherBody;
    private float speed;

	// Use this for initialization
	void Start () {
        time = 0f;

        speed = 0f;
        
	}

	
	// Update is called once per frame
	void Update () {
        
        time += Time.deltaTime;
        Debug.Log(time + "  delta time: " + Time.deltaTime);
        if (time > delay /*&& !other.transform.position.Equals(transform.position)*/)
        {
            speed = Vector3.Distance(other.transform.position, transform.position) / Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, other.transform.position, 20f * Time.deltaTime);
            //transform.position = Vector3.Lerp(transform.position, other.transform.position, .01f * Time.deltaTime);
            
        }
        //else if(other.transform.position.Equals(transform.position))
        //{
        //    time = 0f;
        //}
        
        /*float differentDistance = Vector3.Distance(other.transform.position, transform.position);
        if (differentDistance > swordSize)
        {
            speed = Vector3.Distance(other.transform.position, transform.position);
            //transform.position = Vector3.MoveTowards(transform.position, other.transform.position, speed * .9f);
            //if (differentDistance <= swordSize)
            //{
            //    transform.position = Vector3.MoveTowards(transform.position, other.transform.position, speed);
            //}
            transform.position = Vector3.Lerp(transform.position, other.transform.position, .5f * Time.deltaTime);
            //transform.position = other.transform.position;
        }*/
        
        Vector3 newRotation = new Vector3(other.transform.eulerAngles.x, 
            other.transform.eulerAngles.y, other.transform.eulerAngles.z);
        gameObject.transform.eulerAngles = newRotation;
        

	}
}
