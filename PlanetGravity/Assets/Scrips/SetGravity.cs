using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGravity : MonoBehaviour
{
    [SerializeField] GameObject centerOfGravity;
    [SerializeField] GameObject player;


    Vector2 dir;
    
    void Update()
    {
        dir = centerOfGravity.transform.position - player.transform.position;
        player.transform.Translate(dir * Time.deltaTime);
    }
}
