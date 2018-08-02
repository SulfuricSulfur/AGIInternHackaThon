using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Seek : MonoBehaviour {
    //Get the target and seek it
    public GameObject targetGame;
    private DefaultTrackableEventHandler targetTrack;
    private Transform target;

    public GameObject parent;
    private DefaultTrackableEventHandler parentTrack;

    private float speed;
    private float rotateSpd;

    public ParticleSystem particles;

    public Rigidbody rb;
	// Use this for initialization
	void Start () {

        speed = Random.Range(.1f, 2.5f);
        rotateSpd = Random.Range(200f, 350f);
        target = targetGame.transform;
        parentTrack = GetComponentInParent<DefaultTrackableEventHandler>();
        targetTrack = GetComponentInParent<DefaultTrackableEventHandler>();
        //rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
    void FixedUpdate(){

        rb.velocity = transform.forward * speed;

        var targetRotation = Quaternion.LookRotation(target.position - transform.position);
        rb.MoveRotation(Quaternion.RotateTowards(transform.rotation, targetRotation, rotateSpd));
    }
}
