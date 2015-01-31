using UnityEngine;
using System.Collections;

public class groupTogether : Photon.MonoBehaviour {

	public Transform TargetObject;
	private float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, TargetObject.position, step);
	}
}
