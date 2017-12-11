using UnityEngine;
using System.Collections;

public class Pose2 : MonoBehaviour {

	public Vector3 pos2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		pos2= transform.position;
		//Debug.Log("pos2 is " + pos2);
	
	}
}