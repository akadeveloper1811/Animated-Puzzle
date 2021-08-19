using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class levelselect : MonoBehaviour
{
  

     public void puzzle()
  {
      SceneManager.LoadScene("puzzle 1");
  }
        
        public void second()
        {
            SceneManager.LoadScene("puzzle 2");
        }
    
    public void third()
    {
        SceneManager.LoadScene("puzzle3");
    }
}
