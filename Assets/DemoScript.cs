using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    [SerializeField] 
    private GameObject square;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        square.transform.position = new Vector3(0, 0, 0);
        square.SetActive(false);
        Debug.Log(square.activeSelf);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }

    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }
}
