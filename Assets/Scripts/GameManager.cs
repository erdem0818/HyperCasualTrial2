using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using SlippyRoad;
using SlippyRoad.Enums;

public class GameManager : MonoBehaviour
{   
    public States states;

    [SerializeField] private BasedObject[] _basedObjects;

    public BasedObject[] basedObjects
    {
        get => _basedObjects;
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
        GameEvents.instance.GameOver += SetGameOver;
        GameEvents.instance.StartLevel += LoadLevel;
        GameEvents.instance.CompleteLevel += SetFinish;
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
        GameEvents.instance.GameOver -= SetGameOver;
        GameEvents.instance.StartLevel-= LoadLevel;
        GameEvents.instance.CompleteLevel -= SetFinish;
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
    private void LoadLevel()
    {
        FileManager fileManager = new FileManager();
        fileManager.GetPlayer();
    }
}
