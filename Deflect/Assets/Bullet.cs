using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    [SerializeField] float bulletLife;

    private float dieTime;
    public LayerMask swordLayer;
    public Transform testTransform;
    public float bulletSpeed;
    private Rigidbody bulletRB;

	// Use this for initialization
	void Start () {
        dieTime = Time.time + bulletLife;
        bulletRB = gameObject.GetComponent<Rigidbody>();
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
            Transform bulletTarget = testTransform.transform; //findDeflectTarget();
            Physics.IgnoreCollision(collision.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
        
            gameObject.transform.LookAt(bulletTarget);
            bulletRB.velocity = transform.forward * bulletSpeed;
    }

    Transform findDeflectTarget()
    {
        //Transform output = new Transform();

        Transform output = testTransform.transform;

        return output;
    }

}
