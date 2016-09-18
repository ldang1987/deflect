using UnityEngine;
using System.Collections;

public class swordScriptLightSaber : MonoBehaviour
{

    [SerializeField]
    private Rigidbody swordRigidbody;
    [SerializeField]
    private Vector3 oldpos;
    [SerializeField]
    private Vector3 newpos;
    [SerializeField]
    private Vector3 velocity;

    // Use this for initialization
    void Start()
    {
        swordRigidbody = gameObject.GetComponent<Rigidbody>();
        oldpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        float flip = 1;
        if (transform.rotation.eulerAngles.z < 180 && transform.rotation.eulerAngles.z > 0)
        {
            flip = -1;
        }

        newpos = transform.position;
        var media = (newpos - oldpos);
        velocity = media / Time.deltaTime;
        oldpos = newpos;
        newpos = transform.position;



        Vector3 targetScale = new Vector3(flip * velocity.z * .015f + .05f, .5f, .05f);
        Vector3 newScale = Vector3.Lerp(transform.localScale, targetScale, .5f);

        transform.localScale = newScale;

        Debug.Log(transform.rotation.eulerAngles);
    }
}
