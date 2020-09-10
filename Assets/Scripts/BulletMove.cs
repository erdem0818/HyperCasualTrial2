using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{ 
    Rigidbody _rigidbody;

    [SerializeField]
    private float speed;

    void Start()
    {
       _rigidbody = GetComponent<Rigidbody>();
       
       //Time.deltaTime kullanırsak farklı hızları oluyor nesnelerin.
       Vector3 dir = new Vector3(2f,-1f,0f);
       _rigidbody.velocity = dir*Time.fixedDeltaTime *speed;
    }
}
