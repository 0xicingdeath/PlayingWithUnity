using UnityEngine;
using System.Collections;

//providing access to Unity Library 
public class Move : MonoBehaviour 
{
	public float speed; 
	// Use this for initialization -> constructor equipment 
	void Start () 
	{
		speed = 3; 
		print ("Hello, World!");
		transform.position = new Vector3 (0, 0, 0);
	}

	// Update is called once per frame -> equivalence while(true) loop
	void Update () 
	{
		if (Input.GetKey(KeyCode.LeftArrow)) 
		{
			transform.position -= speed*Time.deltaTime * (new Vector3 (1, 0, 0));
		} //end of if statement

		if (Input.GetKey(KeyCode.RightArrow)) 
		{
			transform.position += speed*Time.deltaTime*(new Vector3 (1, 0, 0));
		} //end of if statement

		if (Input.GetKey(KeyCode.UpArrow)) 
		{
			transform.position += speed*Time.deltaTime*(new Vector3 (0, 1, 0));
		} //end of if statement

		if (Input.GetKey(KeyCode.DownArrow)) 
		{
			transform.position += speed*Time.deltaTime*(new Vector3 (0, -1, 0));
		} //end of if statement
		if (Input.GetKey (KeyCode.Space)) 
		{
			
		} 
	}
}
