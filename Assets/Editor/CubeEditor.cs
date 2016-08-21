using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Cube))]
public class CubeEditor : Editor {
	
	//Initialising
	Cube cube;

	private Vector3 localPosition;
	private Quaternion localRotation;
	private float localForce;
	private float newForce;
	
	public override void OnInspectorGUI ()
	{
		
					
		DrawDefaultInspector();
		
		EditorGUILayout.HelpBox("Default parametrs, do not break", MessageType.Info);
		
	}
	
	void OnSceneGUI(){
		
		cube = (Cube)target;
		localPosition = cube.GetComponent<Transform>().position;
		localRotation = cube.GetComponent<Transform>().rotation;
		
		Handles.Label(localPosition+new Vector3(0,cube.force+0.5f,0),"Force: "+cube.force+"");
		
		// Force Handle
		Handles.color = new Color(0.0F+((cube.force-2)/3), 0.0F, 1.0F-((cube.force-2)/3), 1.0F);
		cube.force = Handles.RadiusHandle(localRotation, localPosition, cube.force);
		cube.force = Mathf.Clamp(cube.force,2f,5f );
		
		// Node Points
		
		Handles.color = new Color(1.0F,1.0F,1.0F,1.0F);
		for(int i=0; i < cube.nodePoints.Length;i++){
			cube.nodePoints[i] = Handles.PositionHandle(cube.nodePoints[i],localRotation);
		}
		
//		for(int i=0; i < cube.nodePoints.Length;i++){
//			Handles.DrawLine(cube.nodePoints[i],cube.nodePoints[(int)Mathf.Repeat(i+1,cube.nodePoints.Length)]);
//			
//		}
		
		Handles.DrawLine(localPosition, cube.nodePoints[0]);
		for(int i=0; i < cube.nodePoints.Length-1;i++){
			Handles.DrawLine(cube.nodePoints[i],cube.nodePoints[(int)Mathf.Repeat(i+1,cube.nodePoints.Length)]);
			
		}
		
		
	}
	

	
		
}
