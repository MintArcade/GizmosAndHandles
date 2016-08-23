using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Hitpoint))]
public class HitpointEditor : Editor {

	//Initialising
	Hitpoint hit;
	
	public override void OnInspectorGUI ()
	{
		// Leave default view
		DrawDefaultInspector();
	}
	
	void OnSceneGUI(){
		hit = (Hitpoint)target;
		//Limit groundContacts to the reasonable ammount
		hit.groundContacts = Mathf.Clamp(hit.groundContacts, 0, 5);
		
		Handles.color = new Color(1.0F, 1.0F, 1.0F, 0.5F);
		Handles.DrawSolidDisc(hit.transform.position - new Vector3(0f,0.45f,0f), hit.transform.up, 2.0f);
		Handles.color = new Color(1.0F, 0.0F, 1.0F, 1.0F);
		Handles.DrawWireDisc (hit.transform.position - new Vector3(0f,0.45f,0f), hit.transform.up, 2.0f);
	}
	
}
