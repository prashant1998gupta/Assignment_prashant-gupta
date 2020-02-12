using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_input_Controller : MonoBehaviour {

    public GameObject leftBat;
    public GameObject rightBat;
    public float batSpeed = 10f;

	// Use this for initialization
	void Start () {


    }
	
	// Update is called once per frame
	void Update () {

        // default velocity of zero in every fream..
        leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

        // if we press w then up the bat with 5 velocity
        if (Input.GetKey(KeyCode.W))
        {
            leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, batSpeed, 0f);
        }

        // if we press s then down the bat with 5 velocity 
       else if (Input.GetKey(KeyCode.S))
        {
            leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -batSpeed, 0f);
        }


        // default velocity of zero in every fream..
        rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

        // if we press w then up the bat with 5 velocity
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, batSpeed, 0f);
        }

        // if we press s then down the bat with 5 velocity 
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -batSpeed, 0f);
        }

    }
}
