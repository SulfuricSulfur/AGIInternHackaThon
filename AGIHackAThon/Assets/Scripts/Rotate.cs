using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public int rotateSpd;
    public bool rotateX;
    public bool rotateY;
    public bool rotateZ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(rotateX)
        {
            transform.Rotate(Vector3.right, rotateSpd * Time.deltaTime);
        }
        else if(rotateY)
        {
            transform.Rotate(Vector3.up, rotateSpd * Time.deltaTime);
        }
        else if(rotateZ){
            transform.Rotate(Vector3.forward, rotateSpd * Time.deltaTime);
        }
	}
}
