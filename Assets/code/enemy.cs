using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private float speed = -4f;

    void Start()
    {

    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, 0);

        if (transform.position.y <= -2.56f)
        {
            transform.position = new Vector3(Random.Range(-9f, 9f), 4.54f, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Player")
        {
            Debug.Log("owwwwwww");
            player player = other.transform.GetComponent<player>();
            if(player != null){
                player.ow_that_hurt();
            }
            Destroy(this.gameObject);
        }
        if (other.transform.tag == "Laser")
        {
            Debug.Log("aAAAAAAAAAAAAAAAAAAAAAa");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}

