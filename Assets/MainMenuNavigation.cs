using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuNavigation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonStartClick()
    {
        Debug.Log("Start");
        SceneManager.LoadScene("MazeGame");
    }
    
    public void ButtonExitClick()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
