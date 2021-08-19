using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
  public void Playgame()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

  public void quitgame()
  {
      Debug.Log("quit!");
      Application.Quit();

  }
}
