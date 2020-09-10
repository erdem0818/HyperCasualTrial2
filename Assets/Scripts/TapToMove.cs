using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Splines;

public class TapToMove : MonoBehaviour
{ 
    [SerializeField]
    private float _speed;

    SplineFollower _splineFollower;
    bool Up;

    void Start()
    {
        _splineFollower = GetComponent<SplineFollower>();

        _splineFollower.followSpeed =0;
    }

    void Update()
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
