using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public float sizeModifier = .5f;
    public string newName = "Cubie ";
    public bool isRotated = false;

    void Start() {
        transform.name = ImproveName(newName);

        if (isRotated) {
            Debug.Log("Is rotated");
            transform.localEulerAngles = Vector3.one * 45;
        }
    }   

    void Update() {
        transform.localScale = Vector3.one * sizeModifier;
    }

    string ImproveName(string name) {
        return "~~[" + name + "]~~";
    }
}
