using UnityEngine;

namespace SlippyRoad
{

    public class BulletInteractions : BasedObject , IMove
    {
        [SerializeField] private float _speed;
        [SerializeField] private Vector3 _direction;
        private void OnEnable()
        {
            Move(_speed,_direction);
        }
        public void Move(float speed, Vector3 direction)
        {
            this.gameObject.GetComponent<Rigidbody>().velocity += direction.normalized * speed* Time.fixedDeltaTime;
        }
    }
}

