using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{

    private float speed = 2.0f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Move();
    }

    // Update is called once per frame
    public void Move()
    {
        Vector3 randomDir = new Vector3(Random.Range(-1f,1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        rb.velocity = randomDir*speed;

    }

    private void Update()
    {
        rb.velocity = rb.velocity.normalized*speed; 
    }
}
