using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager gameManager;

    [SerializeField]
    private float money;

    public Text networth;
    public Text cost;
    public float amount;

	// Use this for initialization
	void Start () {
        gameManager = this;
        updateUI();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void getMoney(float amount) {
        money += amount;
        updateUI();
    }

    public void reduceMoney(float amount) {
        if (enoughMoney(amount) == true)
        {
            money -= amount;
            updateUI();
        }
    }

    public bool enoughMoney(float amount) {
        if (amount >= money) {
            return true;
        }
        return false;
    }

    public void updateUI() {
        networth.text = "$ " + money.ToString("N2");
    }

    public void gotoNextScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }



}
