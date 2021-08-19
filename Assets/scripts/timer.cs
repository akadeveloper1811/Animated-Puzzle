using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    
    float currenttime = 0f;
    float startingtime = 10f;
    [SerializeField] Text count ;
    
    void Start()
    {
         currenttime = startingtime;
    }

   
    void Update()
    {
        currenttime -= 1*Time.deltaTime;
        count.text = currenttime.ToString ("0");
        if(currenttime <= 0)
        {
            currenttime = 0;
            SceneManager.LoadScene("selectpuzzle");
           
        }
    }
}
