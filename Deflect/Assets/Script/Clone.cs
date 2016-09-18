using UnityEngine;
using System.Collections;

public class Clone : MonoBehaviour {

    private Vector3 lastPosition;

    [SerializeField]
    private GameObject cloneSword;
    [SerializeField]
    private float swordSize = 0.02f;

    // Use this for initialization
    void Start()
    {
        // transform == gameObject.GetComponent<Transform>();
        lastPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        float differentDistance = Vector3.Distance(lastPosition, transform.position);
        //if (differentDistance > swordSize)
        /*{
            GameObject temp = Instantiate(cloneSword, originalTransform.position, originalTransform.rotation) as GameObject;
            temp.transform.parent = gameObject.transform;
            originalTransform = gameObject.GetComponent<Transform>();
        }*/
        float swordCount = differentDistance / swordSize;
        //int i = 1;
        for(int i = 1; i <= swordCount; i++)
        {
            Vector3 pos = Vector3.Lerp(lastPosition, transform.position, ((float)i) / swordCount);

            GameObject temp = Instantiate(cloneSword, pos, transform.rotation) as GameObject;
            temp.transform.parent = gameObject.transform;
           
        }

        lastPosition = transform.position;
    }
}
