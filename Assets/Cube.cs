using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

	public float force;
	
	public Vector3[] nodePoints;
	
		
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnDrawGizmos(){
		
		Gizmos.color = new Color(0.0F, 0.0F, 1.0F, 0.8F);
		//Gizmos.
		Gizmos.DrawCube(transform.position+new Vector3( 0f,-0.5f,0f) , new Vector3( 3.0f,0.1f,3.0f));
		
		Gizmos.color = new Color(0.0F, 0.0F, 1.0F, 0.2F);
		for(int i=0; i < nodePoints.Length;i++){
			Gizmos.DrawSphere (nodePoints[i],0.5f);
		}
		
		Gizmos.color = new Color(0.0F, 0.0F, 0.5F, 0.2F);
		Gizmos.DrawLine(transform.position,nodePoints[0]);
		for(int i=0; i < nodePoints.Length-1;i++){
			Gizmos.DrawLine(nodePoints[i],nodePoints[i+1]);
		}
	}
}
