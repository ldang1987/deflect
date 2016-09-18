using UnityEngine;
using System.Collections;

public class Clone : MonoBehaviour {

    private Transform originalTransform;

    [SerializeField]
    private GameObject cloneSword;
    [SerializeField]
    private float swordSize = 0.02f;

	// Use this for initialization
	void Start () {
        originalTransform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        //float differentDistance = Vector3.Distance(originalTransform.position, transform.position);
        //if (differentDistance > swordSize)
        {
            Instantiate(cloneSword, originalTransform.position, originalTransform.rotation);
            originalTransform = gameObject.GetComponent<Transform>();
        }

	}
}
