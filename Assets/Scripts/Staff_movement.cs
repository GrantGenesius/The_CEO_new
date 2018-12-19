using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class Staff_movement : MonoBehaviour {
    public Camera cam;
    public NavMeshAgent agent;
    public Rigidbody Prefab;
    public Transform locateStaffToTrain;
    public Transform locateStaffToWork;
    public Transform locateStaffToMarket;
    public GameObject selectedStaff;

	// Use this for initialization
	void Start () {
        locateStaffToTrain = GameObject.Find("training division").transform;
        //locateStaffToMarket = GameObject.Find("marketing division").transform;
        //locateStaffToWork = GameObject.Find("work division").transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //agent.SetDestination(hit.point);
                if (!EventSystem.current.IsPointerOverGameObject()) {
                    if(hit.transform.gameObject.tag == "Staff"){
                        selectedStaff = hit.transform.gameObject;
                        agent = selectedStaff.GetComponent(typeof(NavMeshAgent)) as NavMeshAgent;
                    }
                }
            }

        }
	}

    public void TrainStaff() {
        
        agent.destination = locateStaffToTrain.position;
    }

    public void MarketStaff() {
        agent.destination = locateStaffToMarket.position;
    }

    public void WorkStaff() {
        agent.destination = locateStaffToWork.position;
    }
}
