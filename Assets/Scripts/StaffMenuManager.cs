using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class StaffMenuManager : MonoBehaviour {

    public GameObject spawned_staff_prefab;
    public GameObject spawn_point;

    [SerializeField]
    private staff_list[] staff_list;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Hire_new_staff() {
        Instantiate(spawned_staff_prefab, spawn_point.transform.position , Quaternion.identity);
    }
}

[Serializable]
public class staff_list {
    public string staff_name;
    public int staff_lv;
    public int staff_xp;
    public int staff_gpm;
}
