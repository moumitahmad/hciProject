using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class FreezeScript : MonoBehaviour
{

    public Sprite pause;
    public Sprite play;
    public Button but;
    public Texture2D screenShot;


    public void ChangeImage()
    {
        if (but.image.sprite == play)
            but.image.sprite = pause;
        else
        {
            but.image.sprite = play;
        }
    }

    public void FreezeScreen()
    {
        if(but.image.sprite == play)
            CameraDevice.Instance.Stop();

        if (but.image.sprite == pause)
            CameraDevice.Instance.Start();
    }

}
