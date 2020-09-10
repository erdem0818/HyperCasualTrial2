using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Base;
using System;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private BasedObject[] basedObjects;
     

    private void Awake()
    {
        SetUpBaseObjects();
        CallBaseObjectsAwake();

    }
    private void Start()
    {           
        CallBaseObjectsStart();
    }
    private void Update()
    {
        CallBaseObjectsUpdate();
    }
    private void FixedUpdate()
    {
        CallBaseObjectsFixedUpdate();
    }
    private void LateUpdate()
    {
        CallBaseObjectsLateUpdate();
    }
    private void OnDestroy()
    {
        CallBaseObjectsDestroy();
    }
    private void OnGameOver()
    {
        CallBaseObjectsGameOver();
    }

    private void SetUpBaseObjects()
    {
        basedObjects = FindObjectsOfType<BasedObject>();
    }
    private void CallBaseObjectsAwake()
    {
        foreach(var e in basedObjects)
        {
            e.BaseObjectAwake();
        }
    }
    private void CallBaseObjectsStart()
    {
        foreach(var e in basedObjects)
        {
            e.BaseObjectStart();
        }
    }
    private void CallBaseObjectsUpdate()
    {
        foreach(var e in basedObjects)
        {
            e.BaseObjectUpdate();
        }
    }
    private void CallBaseObjectsFixedUpdate()
    {
        foreach (var e in basedObjects)
        {
            e.BaseObjectFixedUpdate();
        }
    }
    private void CallBaseObjectsLateUpdate()
    {
        foreach (var e in basedObjects)
        {
            e.BaseObjectLateUpdate();
        }
    }
    private void CallBaseObjectsDestroy()
    {
        foreach (var e in basedObjects)
        {
            e.BaseObjectDestroy();
        }
    }
    private void CallBaseObjectsGameOver()
    {
        foreach (var e in basedObjects)
        {
            e.BasedObjectGameOver();
        }
    }
}
