using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 12f;
    [SerializeField]
    private GameObject laserPrefab;
    private float fire = 0.5f;
    private float fire_now = -1f;
    public int life = 3;


    void Start()
    {
        transform.position = new Vector3(0, 0, 0);

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > fire_now)
        {
            fire_now = Time.time + fire;
            Vector3 offset = new Vector3(transform.position.x, transform.position.y + 0.6f, 0);
            Instantiate(laserPrefab, offset, Quaternion.identity);
        }
        moving();
    }

    void moving()
    {
        float movex = Input.GetAxis("Horizontal");
        float movey = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * _speed * movex * Time.deltaTime);
        transform.Translate(Vector3.up * _speed * movey * Time.deltaTime);
        if (transform.position.y >= 3.51f)
        {
            transform.position = new Vector3(transform.position.x, 3.51f, 0);
        }
        else if (transform.position.y <= -1.5f)
        {
            transform.position = new Vector3(transform.position.x, -1.5f, 0);
        }
        if (transform.position.x <= -9.3f)
        {
            transform.position = new Vector3(9.3f, transform.position.y, 0);
        }
        else if (transform.position.x >= 9.3f)
        {
            transform.position = new Vector3(-9.3f, transform.position.y, 0);
        }

    }

    public void ow_that_hurt(){
       life --;
       if(life < 1){
       Destroy(this.gameObject);
       } 
    }
}
