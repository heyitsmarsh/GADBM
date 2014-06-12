using UnityEngine;
using System.Collections;

public class player : MonoBehaviour
{

	public Vector2 jumpForce = new Vector2(0, 300);
	

	void Update ()
	{
	
		if (Input.GetKeyUp("space"))
		{
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(jumpForce);
		}
	}
}
