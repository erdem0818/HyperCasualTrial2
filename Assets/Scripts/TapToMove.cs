using UnityEngine;
using Dreamteck.Splines;

namespace SlippyRoad
{
    public class TapToMove : BasedObject
    { 
        GameManager gameManager;
        [SerializeField] private float _speed;

        SplineFollower _splineFollower;
        bool Up=false;

        public override void BaseObjectStart()
        {
            gameManager = FindObjectOfType<GameManager>();
            _splineFollower = GetComponent<SplineFollower>();

            _splineFollower.followSpeed = 0;
        }

        public override void BaseObjectUpdate()
        {
            if(gameManager.states == Enums.States.Started)
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
                
            }
            if(Up)
            {
                _splineFollower.followSpeed -= Time.deltaTime *10;
            }
        }
    }
}
