using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class BallScript : MonoBehaviour
{
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }

        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Hit Wall");
            
        }
    }
    
    
    
}
