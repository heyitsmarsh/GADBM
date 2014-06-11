using UnityEngine;
using System.Collections;

public class SpawnObstacles : MonoBehaviour
{
	private float nextY = 0;
	private float lastY = 0;
	public float maxY;
	public float minY;
	public float div_factor;
	public float ydist;

	public GameObject obstacle;
	float x = 0;
	
	void Update () {
	
		nextY = lastY + Random.Range (-ydist / div_factor, ydist / div_factor);
		nextY = Mathf.Clamp (nextY, minY, maxY);
		//float y = Random.Range (0, 20);
		//float y = lastY + Random.Range(21.89135f, 34.3299f);
		if(x < 1000)
		{
			Instantiate(obstacle, new Vector3(x * 2, nextY, 0),Quaternion.identity);
			lastY = nextY;
			x++;
		}
		Debug.Log(x);
	}
}