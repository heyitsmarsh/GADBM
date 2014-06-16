using UnityEngine;
using System.Collections;

public class player : MonoBehaviour
{

	public Vector3 jumpForce = new Vector3(0, 300);
	public float speed = 1;


	void Update ()
	{


		//rigidbody.velocity.x = 1;
		Vector3 b = new Vector3(speed,0,0);

		rigidbody.AddForce(b);
		if (Input.GetKeyUp("space"))
		{
			//rigidbody.velocity = Vector3.zero;
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

