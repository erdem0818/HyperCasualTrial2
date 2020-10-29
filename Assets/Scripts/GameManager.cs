using UnityEngine;
using SlippyRoad;
using SlippyRoad.Enums;
using Dreamteck.Splines;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{   
    public States states;

    [SerializeField] private BasedObject[] _basedObjects;

    public BasedObject[] basedObjects
    {
        get => _basedObjects;
    }

    private void OnEnable()
    {
        GameEvents.instance.GameOver += SetGameOver;
        GameEvents.instance.CompleteLevel += SetFinish;
    }
    private void OnDisable()
    {
        GameEvents.instance.GameOver -= SetGameOver;
        GameEvents.instance.CompleteLevel -= SetFinish;
    }
    private void Awake()
    {
        states = States.Started;
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
    #region 
    private void SetUpBaseObjects()
    {

        _basedObjects = FindObjectsOfType<BasedObject>();
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
    #endregion 

    private void SetGameOver()
    {
        states = States.GameOver;
    }
    private void SetFinish()
    {
        states = States.Finished;
    } 
}
