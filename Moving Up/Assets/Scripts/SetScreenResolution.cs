using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScreenResolution : MonoBehaviour
{
    
    public int width = 1280;
    public int height = 1920;
    public bool fullscreen = false;

    void Start()
    {
        // Set the resolution to the specified width, height, and fullscreen mode
        Screen.SetResolution(width, height, fullscreen);
    }
}
