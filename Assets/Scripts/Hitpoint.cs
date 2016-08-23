using UnityEngine;
using System.Collections;

public class Hitpoint : MonoBehaviour {
	
	//How many times ball will hit the ground prior to this point. Draw tragectory.
	public int groundContacts = 0;
	
	//To use by designer. Then system will calulate the velocity of the ball.
	public float timeToThisHitpoint = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnDrawGizmos(){
		//Gizmos.DrawGUITexture
		Gizmos.DrawSphere(transform.position,0.5f);	
	}
}
