using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove_2 : MonoBehaviour
{
	[SerializeField] private float Speed;
	private float MoveInput;
	private bool Ground;
	
	private Rigidbody rb;
	
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	void OnCollisionEnter()
	{
		Ground = true;
	}
    // Update is called once per frame
    void Update()
    {
    	MoveInput = Input.GetAxis("Horizontal");
    	rb.velocity = new Vector3(MoveInput * Speed, rb.velocity.y, rb.velocity.z);
    	MoveInput = Input.GetAxis("Vertical");
    	rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, MoveInput * Speed);
    	
    	if (Input.GetKeyDown(KeyCode.Space) && Ground)
    	{
    		Ground = false;
    		rb.AddForce(new Vector3(0,350,0));
    	}
    }
}
