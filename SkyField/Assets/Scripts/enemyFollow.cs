using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public float speed;
    public Transform targetPoint;
    public int stopDistance = 3;
    public int fallBackDistance = 2;
    public int enemyDeck = 1;
    //public GameObject targetPlayer;
    // Start is called before the first frame update
    void Start()
    {
        targetPoint = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }
    private void Update()
    {
        if(Vector3.Distance(transform.position,targetPoint.position) > stopDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);
        }
        else if(Vector3.Distance(transform.position, targetPoint.position) < stopDistance && Vector3.Distance(transform.position, targetPoint.position) > fallBackDistance)
        {
            transform.position = new Vector3(this.transform.position.x,targetPoint.position.y,targetPoint.position.z);
            
            
        }
        else if(Vector3.Distance(transform.position, targetPoint.position) < fallBackDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, -speed * Time.deltaTime);
        }
        if (transform.position.y < enemyDeck)
        {
            transform.position = this.transform.position;
        }
    }


}
