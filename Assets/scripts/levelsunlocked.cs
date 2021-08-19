using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelsunlocked : MonoBehaviour
{
        public Button[] button ;
    int levelpassed;

    void start()
    {
       
        for (int i= 0 ; i< button.Length ; i++)
        {
            button[i].interactable = false;
        }
        
    }
}
