using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemaster : MonoBehaviour
{
    public static int remainigpiece = 4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (remainigpiece == 0)
        {
            SceneManager.LoadScene("bomb");
        }
        
    }
}
