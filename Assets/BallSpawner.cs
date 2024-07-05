using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject ball;
    private Vector3 _startPosition = new Vector3(-4.72f,2.6f,0);
    private Quaternion _startRotation = Quaternion.Euler(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ball, _startPosition, _startRotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
