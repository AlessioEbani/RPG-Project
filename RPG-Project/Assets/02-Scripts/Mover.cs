using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour {

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            MoveToCursor();
        }
        
    }

    private void MoveToCursor() {
        //lastRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit=Physics.Raycast(ray, out hit);
        if (hasHit) {
            GetComponent<NavMeshAgent>().destination = hit.point;
        }
    }
}
