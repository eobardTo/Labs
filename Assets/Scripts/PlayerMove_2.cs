using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove_1 : MonoBehaviour
{
	[SerializeField] private float speed;

    void Update()
    {
    	movement();
    }
    void movement()
    {
    	if (Input.GetKey(KeyCode.W))
    	{
    		transform.position += transform.forward * speed;
    	}
    	if (Input.GetKey(KeyCode.S))
    	{
    		transform.position -= transform.forward * speed;
    	}
    	if (Input.GetKey(KeyCode.A))
    	{
    		transform.position -= transform.right * speed;
    	}
    	if (Input.GetKey(KeyCode.D))
    	{
    		transform.position += transform.right * speed;
    	}
    	if (Input.GetKey(KeyCode.Space))
    	{
    		transform.position += Vector3.up * speed;
    	}
    }
}
