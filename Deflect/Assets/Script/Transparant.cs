using UnityEngine;
using System.Collections;

public class Transparant : MonoBehaviour
{
    public GameObject[] swords;
    public float startAlpha = 1.0f;
    public float endAlpha = 0.0f;

	// Use this for initialization
	void Start () {
        int swordCounter = 0;
        while (swordCounter < swords.Length)
        {
            Renderer colorTarget = swords[swordCounter].GetComponentInChildren<Renderer>();
            Color original = colorTarget.material.color;
            original.a = Mathf.Lerp(startAlpha, endAlpha, (float)swordCounter / swords.Length);
            colorTarget.material.color = original;
            swordCounter++;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
