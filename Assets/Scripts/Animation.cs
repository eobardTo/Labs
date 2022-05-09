using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
	public Animator anim;
	private bool enter;

    // Update is called once per frame
    private void Update()
    {
    	if (enter == true && Input.GetKeyDown(KeyCode.E))
    	{
    		anim.SetBool(("Pod"), true);
    	}
    	else if (enter == false)
    	{
    		anim.SetBool(("Pod"), false);
    	}
    }
    private void OnTriggerEnter(Collider other)
    {
    	enter = true;
    }
    private void OnTriggerExit(Collider other)
    {
    	enter = false;
    }
}
