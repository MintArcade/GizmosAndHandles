using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class BallController : MonoBehaviour {
	
	// If true, show time approximation for each hitpoint
	public bool automaticSpeed = false;
	
	// Usefull for penalty kicks, where the ball is stationary
	// at the begining of the highlight.
	
	public float initialDelay = 0f;
	
	//All the hitpoints
	public Transform[] hitpoints;
	
	public void Start( )
	{
		Debug.Log( "I have a Bezier curve handle attached!" );
	}
	
	void OnDrawGizmosSelected(){
		
		// Scan each hitpoint and get all of the details
		//int childCount = transform.childCount;
		//for (int i = 0; i < childCount; i++) {
			//Transform hitpointChild = gameObject.transform.GetChild(i);
			

		//}
		
	}
	
	void OnDrawGizmos(){
		
		// Populating Hitpoints list with all hitpoints
		int childCount = transform.childCount;
		hitpoints = new Transform[childCount];			
		for (int i = 0; i < childCount; i++) {
			Transform hitpointChild = gameObject.transform.GetChild(i);
			
			hitpoints.SetValue(hitpointChild,i);

		}
	}
}
