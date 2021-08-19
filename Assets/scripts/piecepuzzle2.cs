using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class piecepuzzle2 : MonoBehaviour
{
    private Vector3 Rightposition ;
     public bool InRightPosition;
   public bool  Selected;
   

       void Start()
    {
       
        
        Rightposition = transform.position;
        transform.position = new Vector3(x: Random.Range(0f,4.5f),y: Random.Range(-2f,2));
        

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(a: transform.position, b: Rightposition) < 0.5f)
        {
            if(!Selected)
           {       
               if(InRightPosition == false)
               {
                   transform.position = Rightposition;
                   InRightPosition = true;
                   GetComponent<SortingGroup>().sortingOrder = 0;
                   gmp2.remainigpiece -= 1;
               }
           }
        }
    }
   
}
