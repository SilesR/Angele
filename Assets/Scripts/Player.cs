using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float speed = 2f;
	public Vector2 maxVelocity = new Vector2(2,3);
	public float velocidad = 5f;
	//public Light linterna;

	// Use this for initialization
	void Start () {

		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		var absVelX = Mathf.Abs (rigidbody.velocity.x);
		var forceX = 0f;
		var forceY = 0f;
		
		// Calculate Velocity X
		if (Input.GetKey("right"))
		{
			
			//Esto lo que hace es frenar cuando voy a la izquierda y pulso a la derecha
			if(rigidbody.velocity.x <= 0){
				//rigidbody.AddForce (new Vector3 (velocidad, 0, 0), ForceMode.Impulse);
				rigidbody.velocity = new Vector3(rigidbody.velocity.x+velocidad, 0,0);
			}
			if(absVelX < maxVelocity.x)
				forceX = speed;
			
			//Esto pone el sprite mirando a la derecha
			this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y, this.transform.localScale.z);
			
		}
		else if (Input.GetKey("left"))
		{
			//Esto lo que hace es frenar cuando voy a la derecha y pulso a la izquierda
			if(rigidbody.velocity.x >= 0)
				//rigidbody.AddForce (new Vector3 (-velocidad, 0, 0), ForceMode.Impulse);
				rigidbody.velocity = new Vector3(rigidbody.velocity.x-velocidad, 0,0);
			
			if (absVelX < maxVelocity.x)
				forceX = -speed;
			//Esto pone el sprite mirando a la izquierda
			this.transform.localScale = new Vector3(-this.transform.localScale.x, this.transform.localScale.y, this.transform.localScale.z);
			
		}

		}
}