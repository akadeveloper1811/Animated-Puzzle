using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EZCameraShake;

 
public class bombscript1 : MonoBehaviour
{
    
    public float fieldofimpact;

    public float force;
    public GameObject explosioneffect;

    public LayerMask layerTofit;
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        
      
        if (Input.GetKeyDown(KeyCode.Space))
        {
            explode();
        }
        
    }

    void explode()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, fieldofimpact, layerTofit);

        foreach (Collider2D obj in objects)
        {
            Vector2 direction = obj.transform.position - transform.position;

            obj.GetComponent<Rigidbody2D>().AddForce(direction * force);
            Destroy(gameObject);
        }
              
            CameraShaker.Instance.ShakeOnce(4,4,0.1f,1f);
            GameObject explosioneffectIns = Instantiate(explosioneffect, transform.position, Quaternion.identity);
            Destroy(explosioneffectIns, 10);
            
           
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, fieldofimpact);
    }
   
}
