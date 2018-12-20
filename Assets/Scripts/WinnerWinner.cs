using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerWinner : MonoBehaviour {

    void Start () {
	}
	
	void Update () {
	}

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            Application.Quit();
        }
    }
}
