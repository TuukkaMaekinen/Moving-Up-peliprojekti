using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraAspect : MonoBehaviour
{
    void Start()
    {
        float targetAspect = 1280f / 1920f;
        float windowAspect = (float)Screen.width / (float)Screen.height;
        float scaleHeight = windowAspect / targetAspect;

        if (scaleHeight < 1.0f)
        {
            Camera.main.backgroundColor = Color.black; // Mustat palkit
            Rect rect = Camera.main.rect;
            rect.width = 1.0f;
            rect.height = scaleHeight;
            rect.x = 0;
            rect.y = (1.0f - scaleHeight) / 2.0f;
            Camera.main.rect = rect;
        }
        else
        {
            Camera.main.backgroundColor = Color.black; // Mustat palkit
            float scaleWidth = 1.0f / scaleHeight;
            Rect rect = Camera.main.rect;
            rect.width = scaleWidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scaleWidth) / 2.0f;
            rect.y = 0;
            Camera.main.rect = rect;
        }
    }
}

    //void Start()
    //{
    //    // Asetetaan kameran kuvasuhteeksi 1280x1920
    //    //float targetAspect = 1280f / 1920f;
    //    //float windowAspect = (float)Screen.width / (float)Screen.height;

    //    float targetAspect = 1280f / 1920f;
    //    float windowAspect = (float)Screen.width / (float)Screen.height;
    //    float scaleFactor = targetAspect / windowAspect;
    //    float scaleHeight = windowAspect / targetAspect;

    //    Camera.main.orthographic = true;

    //    // Jos ikkuna on kapeampi kuin kohdekuvasuhde
    //    if (scaleFactor > 1.0f)
    //    {
    //        Camera.main.orthographicSize *= scaleFactor;
    //    }

    //    if (scaleHeight < 1.0f)
    //    {
    //        Rect rect = Camera.main.rect;
    //        rect.width = 1.0f;
    //        rect.height = scaleHeight;
    //        rect.x = 0;
    //        rect.y = (1.0f - scaleHeight) / 2.0f;
    //        Camera.main.rect = rect;
    //    }
    //    else
    //    {
    //        float scaleWidth = 1.0f / scaleHeight;
    //        Rect rect = Camera.main.rect;
    //        rect.width = scaleWidth;
    //        rect.height = 1.0f;
    //        rect.x = (1.0f - scaleWidth) / 2.0f;
    //        rect.y = 0;
    //        Camera.main.rect = rect;
    //    }
    //}

