using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 3.5f;
    public float jumpingForce = 250f;
    public float rotatingSpeed = 100f;

    private bool canJump = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("right")) {
            transform.RotateAround(transform.position, Vector3.up, rotatingSpeed * Time.deltaTime);
        }

        if (Input.GetKey("left")) {
            transform.RotateAround(transform.position, Vector3.up, -rotatingSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown("space") && canJump) {
            canJump = false;
            GetComponent<Rigidbody>().AddForce(0, jumpingForce, 0);
        }

        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey("down"))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }


        if (Input.GetKey("left") && Input.GetKey("up")) {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey("right") && Input.GetKey("down"))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Floor")
        {
            canJump = true;
        }
    }
}
