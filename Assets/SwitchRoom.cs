﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchRoom : MonoBehaviour {

    public void ChangeScene()
    {

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            //SceneManager.LoadScene(1);
            //Initiate.Fade
            Initiate.Fade("SecondRoom", Color.black, 1);

        }
        else
        {
            //SceneManager.LoadScene(0);
            Initiate.Fade("MainScene", Color.black, 1);   
        }
        
    }
}
