using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SlippyRoad;

public class CameraFollow : BasedObject
{   
    private ChangeLevel change;
    
    [SerializeField] private Transform target;
    [SerializeField] float smoothing;

    [SerializeField] private Vector2 maxPosition;
    [SerializeField] private Vector2 minPosition;

    public override void BaseObjectAwake()
    {
        change = FindObjectOfType<ChangeLevel>();
    }
    public override void BaseObjectLateUpdate()
    {
        if (transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            targetPosition.x = Mathf.Clamp(target.position.x,minPosition.x,maxPosition.x);
            targetPosition.y = Mathf.Clamp(target.position.y,minPosition.y,maxPosition.y);

            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }
    }
}
