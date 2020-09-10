using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;
using Base;

public class TapToMove : BasedObject
{ 
    [SerializeField]
    private float _speed;

    SplineFollower _splineFollower;
    bool Up=false;

    public override void BaseObjectStart()
    {
        _splineFollower = GetComponent<SplineFollower>();

        _splineFollower.followSpeed = 0;
    }

    public override void BaseObjectUpdate()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            _splineFollower.followSpeed =_speed;
            Up = false;
        }
        else if(Input.GetKeyUp(KeyCode.A))
        {    
            Up = true;
        }
        if(Up)
        {
            _splineFollower.followSpeed -= Time.deltaTime *10;
        }
    }
}
