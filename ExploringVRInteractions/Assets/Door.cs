using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public Vector3 loweredPosition;
    public Vector3 targetPosition;
    public float speed = 0.5f;

	// Use this for initialization
	void Start () {
        targetPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, targetPosition, speed*Time.deltaTime);
	}

    public void LowerDoor() {
        targetPosition = loweredPosition;
    }
}
