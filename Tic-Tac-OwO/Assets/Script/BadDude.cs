using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class BadDude : MonoBehaviour
{
    NavMeshAgent me;

    // Start is called before the first frame update
    void Start()
    {
        me = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        me.SetDestination(GameManager.Instance.player.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameManager.Instance.player.transform.position = new Vector3(-47.2f, 1, 0);
        }
    }

}
