using UnityEngine;
using System.Collections;

public class MouseDrag : MonoBehaviour {

    [SerializeField]
    private float distance = 10f;
    [SerializeField]
    private float speed = .5f;
    [SerializeField]
    private float rotate = 10f;

    private Vector3 screenPoint;
    private Vector3 offset;

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }


	void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 objPostition = Camera.main.ScreenToWorldPoint(mousePosition) + offset;

        transform.position = objPostition;

    }

    void Update()
    {
        transform.Rotate(rotate * Time.deltaTime, 0, 0);
    }


}
