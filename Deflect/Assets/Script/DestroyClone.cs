using UnityEngine;
using System.Collections;

public class DestroyClone : MonoBehaviour {

    [SerializeField]
    private int destroyFrame = 10;
    private int countFrame;
    public float startAlpha = 1.0f;
    public float endAlpha = 0.0f;

    // Use this for initialization
    void Start () {
        countFrame = 0;
	}
	
	// Update is called once per frame
	void Update () {
        countFrame++;
        Renderer colorTarget = gameObject.GetComponentInChildren<Renderer>();
        Color original = colorTarget.material.color;
        original.a = Mathf.Lerp(startAlpha, endAlpha, (float)countFrame / destroyFrame);
        colorTarget.material.color = original;
        if (countFrame >= destroyFrame)
        {
            Destroy(gameObject);
        }
	}
}
