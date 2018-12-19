using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class CEO_movement : MonoBehaviour {
    public Camera cam;
    public NavMeshAgent agent;
    public Rigidbody Prefab;
    public GameObject selectedStaff;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0)){
		    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //Rigidbody RigidPrefab;
            //RigidPrefab = Instantiate(Prefab, hit.point + Vector3.up / 2, Quaternion.Euler(-90, 0, 0));
            
            if (Physics.Raycast(ray, out hit)) {
                //agent.SetDestination(hit.point);
                if(!EventSystem.current.IsPointerOverGameObject())
                agent.destination = hit.point;
                if (hit.collider.tag == "Staff")
                {
                    selectedStaff = hit.transform.gameObject;
                }
            }


        }
        
	}
}
