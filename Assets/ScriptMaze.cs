using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScriptMaze : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField] private GameObject maze;
    
    
    private bool _leftDirection;
    private bool _rotateLeftContinoiusly;
    private bool _rotateRightContinoiusly;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.RightArrow))
        // {
        //     _leftDirection = false;
        // }
        // if (Input.GetKeyDown(KeyCode.LeftArrow))
        // {
        //     _leftDirection = true;
        // }
        
        // if (_leftDirection)
        // {
        //     transform.Rotate(0,0,speed* Time.deltaTime);
        // }
        // else
        // {
        //     transform.Rotate(0,0,-speed* Time.deltaTime);
        // }
        if (_rotateLeftContinoiusly)
        {
            maze.transform.Rotate(0,0,speed* Time.deltaTime);
        }

        if (_rotateRightContinoiusly)
        {
            maze.transform.Rotate(0, 0, -speed * Time.deltaTime);
        }
    }
    public void ChangeDirectionToLeft()
    {
        RotateLeft();
        
    }
    
    public void ChangeDirectionToRight()
    {
        RotateRight();
    }

    private void RotateLeft()
    {
        maze.transform.Rotate(0,0,speed* Time.deltaTime);
    }
    
    private void RotateRight()
    {
        maze.transform.Rotate(0,0,-speed* Time.deltaTime);
    }

    public void StartRotateLeftContinoiusly()
    {
        _rotateLeftContinoiusly = true;
    }
    
    public void StopRotateLeftContinoiusly()
    {
        _rotateLeftContinoiusly = false;
    }
    
    public void StartRotateRightContinoiusly()
    {
        _rotateRightContinoiusly = true;
    }
    
    public void StopRotateRightContinoiusly()
    {
        _rotateRightContinoiusly = false;
    }
}
