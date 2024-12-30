using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Controller : MonoBehaviour
{

    public void Play()
    {
        SceneController.LoadScene(1);
    }

    public void Restart()
        { SceneController.Restart(); 
    }

    public void SceneLoad() 
    { 
        SceneController.LoadScene(0);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
