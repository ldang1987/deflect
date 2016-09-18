using UnityEngine;
using System.Collections;

public class bulletScaler : MonoBehaviour {

    private float startTime;
    private float extendTime;
    private float narrowTime;

	// Use this for initialization
	void Start () {
        startTime = Time.time;
        extendTime = 1.0f;
        narrowTime = 2.0f;

        StartCoroutine(ScaleOverTime(2));
    }
	
	// Update is called once per frame
	void Update () {
	    /*if(Time.time < startTime + extendTime)
        {
            float extendLength = Mathf.Lerp(1, 500, Time.deltaTime / extendTime);
            gameObject.transform.localScale.Set(gameObject.transform.localScale.x, extendLength, gameObject.transform.localScale.z);
        } else if (Time.time < startTime + narrowTime) {
            float scaleDown = Mathf.Lerp(1, 0, Time.deltaTime / extendTime);
            gameObject.transform.localScale.Set(scaleDown, gameObject.transform.localScale.y, scaleDown);
        }*/


	}

    IEnumerator ScaleOverTime(float time)
    {
        Vector3 originalScale = transform.localScale;
        Vector3 destinationScale = new Vector3(.01f, 500f, .01f);

        float currentTime = 0.0f;
        do
        {
            transform.localScale = Vector3.Lerp(originalScale, destinationScale, currentTime / time);

            currentTime += Time.deltaTime;
            yield return null;

        } while (currentTime <= time);


        Destroy(gameObject);
    }
}
