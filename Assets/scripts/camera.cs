using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public float power = 0.7f;
    public float duration = 1.0f;
    public Transform cameram;
    public float slow = 1.0f;
    public bool shake = false;


    Vector3 startPosition;
    float initialduration;

    // Start is called before the first frame update
    void Start()
    {
        cameram = Camera.main.transform;
        startPosition = cameram.localPosition;
        initialduration = duration;

    }

    // Update is called once per frame
    void Update()
    {
        if(shake)
        {
            if(duration>0)
            {
                cameram.localPosition = startPosition + Random.insideUnitSphere * power;
                duration -= Time.deltaTime * slow;
            }

            else
            {
                shake = false;
                duration = initialduration;
                cameram.localPosition = startPosition;      
            }
        }

    }
}
