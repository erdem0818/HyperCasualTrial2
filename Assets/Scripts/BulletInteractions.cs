using UnityEngine;

namespace SlippyRoad
{

    public class BulletInteractions : MonoBehaviour , IMove
    {
        //OYUN BİTİNCE VEYA YANINCA SÜREKLİ CAM SHAKE YAPMASIN

        [SerializeField] private float _speed;
        [SerializeField] private Vector3 _direction;

        Vector3 rot = new Vector3(0f,0f,45f);

        private void OnEnable()
        {
            Move(_speed,_direction);
        }
        public void Move(float speed, Vector3 direction)
        {
            this.gameObject.GetComponent<Rigidbody>().velocity += direction.normalized * speed* Time.fixedDeltaTime;
        }

        void FixedUpdate()
        {
            transform.Rotate(rot * Time.fixedDeltaTime);
        }
    }
}

