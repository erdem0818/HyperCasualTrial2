using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SlippyRoad;

public class CameraFollow : BasedObject
{
    //her level için ayrı min max değerleri var onu bir dizide tut.
    public Transform target;
    [SerializeField]
    float smoothing;

    public Vector2 maxPosition;
    public Vector2 minPosition;

    public override void BaseObjectLateUpdate()
    {
        if (transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            targetPosition.x = Mathf.Clamp(target.position.x, minPosition.x, maxPosition.x);
            targetPosition.y = Mathf.Clamp(target.position.y, minPosition.y, maxPosition.y);
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }
}
