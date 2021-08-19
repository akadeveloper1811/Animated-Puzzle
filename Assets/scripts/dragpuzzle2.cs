using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


public class dragpuzzle2 : MonoBehaviour
{
   public GameObject selectpiece;
   int OIL = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                if(!hit.transform.GetComponent<piecepuzzle2>().InRightPosition)
                {
                     selectpiece = hit.transform.gameObject;
                     selectpiece.GetComponent<piecepuzzle2>().Selected = true;
                     selectpiece.GetComponent<SortingGroup>().sortingOrder = OIL;
                     OIL++;
                }
               

            }
        }
        if(Input.GetMouseButtonUp(0))
        {
            if(selectpiece != null)
            {
                 selectpiece.GetComponent<piecepuzzle2>().Selected = false;
                 selectpiece = null;

            }
           
            
        }

        if (selectpiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selectpiece.transform.position = new Vector3(MousePoint.x,MousePoint.y, 0);
        }
    }
}
