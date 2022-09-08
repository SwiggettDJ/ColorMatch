using System;
using System.Collections;
using UnityEngine;

public class DraggableBehaviour : MonoBehaviour
{
    public bool draggable;
    private Camera cameraObj;
    public Vector3 position, offset;
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        draggable = true;
        yield return new WaitForFixedUpdate();
        
        
        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
    }
}
