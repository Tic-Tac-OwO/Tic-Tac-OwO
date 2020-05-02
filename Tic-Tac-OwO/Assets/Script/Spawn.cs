using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject dude;
    public float timer = 2;
    float clock = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clock += Time.deltaTime;
        if(clock > timer)
        {
            GameObject go = Instantiate<GameObject>(dude);
            go.transform.position = this.transform.position;
            clock = 0;
        }
    }
}
