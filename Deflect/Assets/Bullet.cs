using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    [SerializeField] float bulletLife;
    [SerializeField] GameObject mainCamera;


    private float dieTime;
    public LayerMask swordLayer;
    public Transform testTransform;
    public float bulletSpeed;
    private Rigidbody bulletRB;

	// Use this for initialization
	void Start () {
        dieTime = Time.time + bulletLife;
        bulletRB = gameObject.GetComponent<Rigidbody>();
        mainCamera = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {

        if(Time.time > dieTime)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log("Hit Sword");
        //Transform bulletTarget = testTransform.transform; //findDeflectTarget();
        Physics.IgnoreCollision(collision.gameObject.GetComponent<Collider>(), GetComponent<Collider>());

        Vector3 direction = mainCamera.gameObject.transform.forward;
        Ray lookRay = new Ray(mainCamera.gameObject.transform.position, direction);
        Vector3 newBulletTarget = lookRay.GetPoint(100);

        gameObject.transform.LookAt(newBulletTarget);
        bulletRB.velocity = transform.forward * bulletSpeed;

        Vector3 newRotation = gameObject.transform.rotation.ToEuler();
        newRotation.x -= 90.0f;
        gameObject.transform.rotation = Quaternion.Euler(newRotation);
    }

    Transform findDeflectTarget()
    {
        //Transform output = new Transform();

        Transform output = testTransform.transform;

        return output;
    }

}
