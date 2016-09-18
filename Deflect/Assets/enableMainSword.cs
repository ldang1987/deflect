using UnityEngine;
using System.Collections;

public class enableMainSword : MonoBehaviour {

    [SerializeField]
    private GameObject mainSword;

	// Use this for initialization
	void Start () {
        mainSword.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    void OnDisable()
    {
        mainSword.SetActive(false);
    }

}
