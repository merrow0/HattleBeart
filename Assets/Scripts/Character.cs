using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Vector3 moveToPos;
    public float movementSpeed;

    Rigidbody2D rigid;

	void Start()
    {
        rigid = GetComponent<Rigidbody2D>();

        moveToPos = transform.position;
    }
	
	void Update()
    {
	}

    void FixedUpdate()
    {
        Vector3 heading = moveToPos - transform.position;
        float distance = heading.magnitude;

        if (distance < 0.1f)
        {
            rigid.MovePosition(moveToPos);
            rigid.velocity = Vector3.zero;
        }
        else
        {
            Vector3 normalizedDirection = heading / distance;
            rigid.velocity = normalizedDirection * movementSpeed;
        }
    }
}
