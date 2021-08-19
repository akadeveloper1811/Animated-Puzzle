using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slectpuzzle : MonoBehaviour
{
    public GameObject startpannel;

   public void setpuzzlephoto(Image Photo)
   {
       for(int i =0;i<4;i++)
       {
           GameObject.Find("Piece (" + i + ")").transform.Find("puzzle").GetComponent<SpriteRenderer>().sprite = Photo.sprite;
       }
       startpannel.SetActive(false);
   }
}
