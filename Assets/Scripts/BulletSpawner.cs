using System.Collections;
using UnityEngine;

namespace SlippyRoad
{
    public class BulletSpawner : BasedObject ,IMove
    {
        GameManager gameManager;
        [SerializeField] private GameObject _bullet;
    
        [SerializeField] private float spawnTime;
        

        [SerializeField] Vector3 _bulletDirection;
        [SerializeField] float _speed;

        public override void BaseObjectStart()
        {
            gameManager = FindObjectOfType<GameManager>();
            StartCoroutine(_Spawner());
        }

        private IEnumerator _Spawner()
        {
            while(true)
            {
                if(gameManager.states == Enums.States.Started)
                    Move(_speed,_bulletDirection);
                    
                yield return new WaitForSeconds(spawnTime);   
            }

        }

        public void Move(float speed, Vector3 direction)
        {
            GameObject cloneBullet = Instantiate(_bullet, transform.position,this.transform.rotation);
            cloneBullet.GetComponent<Rigidbody>().velocity += direction * speed* Time.fixedDeltaTime;

            Destroy(cloneBullet,10f);
        }
    }
}
