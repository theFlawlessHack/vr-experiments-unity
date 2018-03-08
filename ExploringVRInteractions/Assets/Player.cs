using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 0.5f;
    public Vector3 castlePosition;
    public bool enteredCastle;

    private Vector3 targetPosition;

	// Use this for initialization
	void Start () {
        targetPosition = transform.parent.position;
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;

        if (Physics.Raycast(transform.position,transform.forward, out hit)) {
            if (hit.transform.GetComponent<DoorButton>() != null) {
                hit.transform.GetComponent<DoorButton>().OnLook();
                MoveToCastle();
            }
        }

        // Shooting at Enemies
        if (Input.GetKeyDown("space")) {
            RaycastHit enemyHit;
            if (Physics.Raycast(transform.position, transform.forward, out enemyHit)) {
                if (hit.transform.GetComponent<Enemy>() != null) {
                    Destroy(hit.transform.gameObject);
                }
            }
        }

        // Movign Logic
        transform.parent.position = Vector3.Lerp(transform.parent.position, targetPosition, speed * Time.deltaTime);
	}

    private void MoveToCastle() {
        targetPosition = castlePosition;
        enteredCastle = true;
    }
}
