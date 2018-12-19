using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class CEO_computer : MonoBehaviour {

    public int isClicked=1;
    public int isTouching=1;
    public GameObject CEO_menu_window;


	// Use this for initialization
	void Start () {
		
	}


	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) { 
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "CEO_computer")
                {
                    isClicked = 0;
                    isTouching = 0;
                    
                }
                else 
                {
                    isClicked = 1;
                    if (!EventSystem.current.IsPointerOverGameObject())
                    {
                        close_CEO_menu();
                        Debug.Log("upgrade menu closed!");
                    }
                }
             
            }
        }
        
	}

    public void OnCollisionStay(Collision coll) { 
        if(coll.gameObject.tag == "CEO" && isClicked == 0){
            if(isTouching == 0){
                open_CEO_menu();
                Debug.Log("upgrade menu opened!");
                isTouching = 1;
            }
        }
    }


    public void open_CEO_menu()
    {
        CEO_menu_window.SetActive(true);
    }

    public void close_CEO_menu() {
        CEO_menu_window.SetActive(false);
    }

}
