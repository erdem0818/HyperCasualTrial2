using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Base;

public class BulletSpawner : BasedObject
{
    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private float spawnTime;

    public override void BaseObjectStart()
    {
        StartCoroutine(_Spawner(bullet));
    }

    private IEnumerator _Spawner(GameObject _bullet)
    {
        while(true)
        {
            GameObject cloneBullet = Instantiate(_bullet, transform.position,this.transform.rotation);
            
            yield return new WaitForSeconds(spawnTime);

            Destroy(cloneBullet,10f);
        }

    }
}
