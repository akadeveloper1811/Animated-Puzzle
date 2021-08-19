using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class jaolevelp : MonoBehaviour
{
    public void Play()
  {
      SceneManager.LoadScene("selectpuzzle");
  }

  public void menu()
  {
      SceneManager.LoadScene("SampleScene");

  }

  public void animate()
  {
      SceneManager.LoadScene("bomb");

  }
  public void animate2()
  {
      SceneManager.LoadScene("airplanefinal");
  }
}
