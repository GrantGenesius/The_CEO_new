using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Staff_Menu : MonoBehaviour {
    public int staff_isclicked = 1;
    public int colliding = 1;
    public GameObject Staff_Menu_Window;
    public GameObject staffMenu;
    public GameObject staffManager;
    public GameObject Canvas;
    public Text staffname;
    public Text staffdetail;



	// Use this for initialization
	void Start () {
        staffMenu = this.gameObject;
        //Staff_Menu_Window = findincludin
        //Staff_Menu_Window = Canvas.transform.GetChild(0).gameObject;
        //Staff_Menu_Window = Canvas.GetComponentInChildren<GameObject>(true);
        //Staff_Menu_Window = Canvas.Find
        //Staff_Menu_Window = GameObject.Find("Staff menu Panel");
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Staff")
                {

                    staff_isclicked = 0;
                    colliding = 0;
                }
                else
                {
                    staff_isclicked = 1;
                    if (!EventSystem.current.IsPointerOverGameObject())
                    {
                        Close_Staff_Menu();
                    }
                }
            }
        }
	}



    void OnCollisionStay(Collision coll) { 
        if (coll.gameObject.tag == "CEO" && staff_isclicked == 0)
        {
            while (colliding == 0)
            {
                Debug.Log("display staff menu now!");
                Show_Staff_Menu();
                colliding = 1;
            }
        }
    }



    public void Show_Staff_Menu() {
        
        Staff_Menu_Window.SetActive(true);
    }

    public void Close_Staff_Menu() {
        Staff_Menu_Window.SetActive(false);
    }

    public void set_trainButton_active() { 
        
    }

    public void set_marketButton_active() { 
    
    }

    public void set_WorkButton_active() { 
    
    }
}
