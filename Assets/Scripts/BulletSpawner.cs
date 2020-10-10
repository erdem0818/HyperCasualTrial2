using System.Collections;
using UnityEngine;
using SlippyRoad.Enums;

namespace SlippyRoad
{
    //BasedObject olunca bulmadı.
    public class BulletSpawner : MonoBehaviour
    {
        GameManager gameManager;
        private GameObject _bullet;
    
        [SerializeField] private float spawnTime;
        

        private void Start()
        {
            gameManager = FindObjectOfType<GameManager>();
            _bullet = GetComponentInChildren<BulletInteractions>().gameObject;

            StartCoroutine(_Spawner());
        }

        private IEnumerator _Spawner()
        {
            while(true)
            {
                if(gameManager.states == States.Started)
                {
                    GameObject cloneBullet = Instantiate(_bullet, transform.position,this.transform.rotation);
                }          
                yield return new WaitForSeconds(spawnTime);   
            }

        }
    }
}
