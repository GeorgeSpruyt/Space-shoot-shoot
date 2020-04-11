using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private float _speed = 12f;
    
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + _speed * Time.deltaTime, 0);
       
       
        if (transform.position.y > 4.8f)
        {
         Destroy(this.gameObject);
        }
    }
}
