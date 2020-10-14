using System.Collections;
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
        bool isDown=false;

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
                if(Input.GetKeyDown(KeyCode.A)&& CheckBool(isDown))
                {
                    _splineFollower.followSpeed =_speed;
                    Up = false;
                }

                if(Input.touchCount>0)
                {
                    Touch touch = Input.GetTouch(0);

                    switch (touch.phase)
                    {
                        case TouchPhase.Began:
                             _splineFollower.followSpeed =_speed;
                            Up = false;
                            break;

               
                        case TouchPhase.Stationary:
                           
                            break;

                        case TouchPhase.Ended:
                            Up = true;
                            break;
                    }
                }
                
            }

            CheckUp();
        }

        
        private void CheckUp()
        {
            if(Input.GetKeyUp(KeyCode.A))
            {    
                Up = true;
            }

            if(Up || gameManager.states == Enums.States.GameOver)
            {
                _splineFollower.followSpeed -= Time.deltaTime *10;
            }
        }


        private bool CheckBool(bool Down)
        {
            if(gameManager.states == Enums.States.Started)
                return Down=true;
            else
                return Down=false;
        }
    }
}
