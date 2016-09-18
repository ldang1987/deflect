using UnityEngine;
using System.Collections;

public class bulletEmitter : MonoBehaviour {

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject bulletScaler;
    [SerializeField] float fireSpeed;
    [SerializeField]
    private GameObject[] targets;

    private Vector3 bulletVelocity;
    private Quaternion targetRotation;

    // Use this for initialization
    void Start () {
        bulletVelocity.x = (-1) * fireSpeed;
        targetRotation = Quaternion.LookRotation(targets[0].transform.position - transform.position);
        Debug.Log("location: " + targetRotation);
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown("e") 
            || SteamVR_Controller.Input(4).GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            StartCoroutine(spawnBullet(2));
            //new Vector3(0.0f, 0.0f, 90.0f)
            //Vector3 tempRotation = targetLocation;
            //Quaternion.Euler(tempRotation)
            GameObject bulletPredictor = Instantiate(bulletScaler, this.transform.position, targetRotation) as GameObject;

        }
	}

    IEnumerator spawnBullet(float time)
    {
        yield return new WaitForSeconds(time);

        //Vector3 tempRotation = targetLocation;
        GameObject instance = Instantiate(bulletPrefab, this.transform.position, targetRotation) as GameObject;
        instance.GetComponent<Rigidbody>().velocity = bulletVelocity;
    }

}