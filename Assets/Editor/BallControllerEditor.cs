using UnityEngine;
using System.Collections;
using UnityEditor;

[ExecuteInEditMode]
[CustomEditor(typeof(BallController))]
public class BallControllerEditor : Editor {
	
	//Initialising
	BallController ball;
	

	public override void OnInspectorGUI(){
		
		DrawDefaultInspector();
	}
	
	void OnSceneGUI(){
		ball = (BallController)target;
		
		ball.transform.RotateAround(new Vector3(0f,1f,0f),0.001f);
		
		// Populating Hitpoints list with all hitpoints
		int childCount = ball.transform.childCount;
		//hitpoints = new Transform[childCount];			
		for (int i = 0; i < childCount; i++) {
			// Get some local variables to work with
			GameObject hitpoint1;
			GameObject hitpoint0; 
			
			//distance between 2 hitpoints
			float distance;
			
			//to automatically calculate an arc
			float timeToThisHitpoint;
			float hitPower;
			
			
			if (i==0) {
				hitpoint1 = ball.transform.GetChild(i).gameObject;
				hitpoint0 = ball.gameObject;
			} else {
				hitpoint1 = ball.transform.GetChild(i).gameObject;
				hitpoint0 = ball.transform.GetChild(i-1).gameObject;
			}
			
			
			
			
			
			
			
			//hitpoint0.
			
			//Can use bezier ;(
			//Handles.DrawBezier(hitpoint0.position,hitpoint1.position,new Vector3(1f,0f,1f),new Vector3(1f,0f,0f),Color.white,null, 0.2f);
			
			
			
			//hitpoints.SetValue(hitpointChild,i);

		}
			
	}

}
