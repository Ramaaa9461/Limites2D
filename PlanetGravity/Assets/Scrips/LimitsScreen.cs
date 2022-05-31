using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitsScreen : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Camera cam;
    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        cam = Camera.main;
    }

    private void Update()
    {
       // setLimits();
    }

    public void setLimits()
    {

        Vector3 viewportPos = cam.WorldToViewportPoint(transform.position + spriteRenderer.bounds.extents);
        Vector3 viewportNeg = cam.WorldToViewportPoint(transform.position - spriteRenderer.bounds.extents);

       

        if (viewportPos.x > 1 ) //Derecho
        {
            transform.position = new Vector3( cam.ViewportToWorldPoint(Vector3.right).x - spriteRenderer.bounds.extents.x, transform.position.y, transform.position.z);
            
        }
        if (viewportNeg.x < 0) //Izquierda
        {
            transform.position = new Vector3(cam.ViewportToWorldPoint(Vector3.zero).x + spriteRenderer.bounds.extents.x, transform.position.y, transform.position.z);

        }

        if (viewportPos.y > 1) //Arriba
        {
            transform.position = new Vector3(transform.position.x ,cam.ViewportToWorldPoint(Vector3.up).y - spriteRenderer.bounds.extents.y, transform.position.z);

        }
        if (viewportNeg.y < 0) //Abajo
        {
          transform.position = new Vector3(transform.position.x, cam.ViewportToWorldPoint(Vector3.zero).y + spriteRenderer.bounds.extents.y, transform.position.z);
        }


    }

}
