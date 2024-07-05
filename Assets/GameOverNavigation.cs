using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverNavigation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ButtonRetryClick()
    {
        Debug.Log("Retry");
        SceneManager.LoadScene("MazeGame");
    }
    
    public void ButtonMenuClick()
    {
        Debug.Log("Menu");
        SceneManager.LoadScene("MainMenu");
    }
}
