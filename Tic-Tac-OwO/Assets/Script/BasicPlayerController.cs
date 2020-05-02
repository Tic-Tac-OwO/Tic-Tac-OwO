using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerController : MonoBehaviour
{
    public GameObject bullet;

    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = getdir();
        movement(v);
        shoot(v);
    }
    Vector3 getdir()
    {
        Vector2 dir = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            dir.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            dir.x += 1;
        }

        if (Input.GetKey(KeyCode.W))
        {
            dir.y += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            dir.y -= 1;
        }
        Vector3 realdir = new Vector3(dir.x, 0, dir.y).normalized * (speed * Time.deltaTime);

        return realdir;
    }


    void shoot(Vector3 v)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate<GameObject>(bullet);
            go.transform.position = this.transform.position;
            go.transform.LookAt(this.transform.position + v);
        }
    }

    void movement(Vector3 v)
    {
       

        this.transform.position += v;
    }
}
