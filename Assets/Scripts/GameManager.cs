﻿using System.Collections.Generic;
using UnityEngine;
using Base;

public class GameManager : MonoBehaviour
{   
    private BasedObject[] BasedObjectsArray;
    [SerializeField]
    private List<BasedObject> _basedObjects;

    public List<BasedObject> basedObjects
    {
        get => _basedObjects;
        set 
        {
            if(value!=_basedObjects)
            {
                _basedObjects = value;
            }
        }
    }


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
        BasedObjectsArray = FindObjectsOfType<BasedObject>();

        for(int i =0; i<BasedObjectsArray.Length; i++)
        {
            _basedObjects.Add(BasedObjectsArray[i]);
        }
    }
    private void CallBaseObjectsAwake()
    {
        foreach(var e in _basedObjects)
        {
            e.BaseObjectAwake();
        }
    }
    private void CallBaseObjectsStart()
    {
        foreach(var e in _basedObjects)
        {
            e.BaseObjectStart();
        }
    }
    private void CallBaseObjectsUpdate()
    {
        foreach(var e in _basedObjects)
        {
            e.BaseObjectUpdate();
        }
    }
    private void CallBaseObjectsFixedUpdate()
    {
        foreach (var e in _basedObjects)
        {
            e.BaseObjectFixedUpdate();
        }
    }
    private void CallBaseObjectsLateUpdate()
    {
        foreach (var e in _basedObjects)
        {
            e.BaseObjectLateUpdate();
        }
    }
    
    private void CallBaseObjectsDestroy()
    {
        foreach (var e in _basedObjects)
        {
            e.BaseObjectDestroy();
        }
    }
    private void CallBaseObjectsGameOver()
    {
        foreach (var e in _basedObjects)
        {
            e.BasedObjectGameOver();
        }
    }
}
