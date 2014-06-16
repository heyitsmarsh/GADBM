using UnityEngine;
using System.Collections;

public class player : MonoBehaviour
{

	public Vector3 jumpForce = new Vector3(0, 300);
	public Vector3 speed = new Vector3(1,0);
	public float maxspeed = 3; 

	void Update ()
	{


		//rigidbody.velocity.x = 1;

		if(rigidbody.velocity.x < maxspeed)
		rigidbody.AddForce(speed);

		if (Input.GetKeyUp("space"))
		{
			//rigidbody.velocity = Vector3.zero;
			rigidbody.velocity = speed;
			rigidbody.AddForce(jumpForce);
		}
	
	/*Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
	if (screenPosition.y > Screen.height || screenPosition.y < 0)
	{
		Die();
	}*/
	}

	void OnCollisionEnter(Collision other)
	{
		Die();
	}
	
	void Die()
	{
		Application.LoadLevel(Application.loadedLevel);
	}

}

