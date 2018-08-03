using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKeyOpen : MonoBehaviour {
    public GameObject door;
    public GameObject key;

    [SerializeField]
    private float distance = 3.0f;

    private DefaultTrackableEventHandler doorTrack;
    private DefaultTrackableEventHandler keyTrack;
	// Use this for initialization
	void Start () {
        doorTrack= door.GetComponentInParent<DefaultTrackableEventHandler>();
        keyTrack = key.GetComponentInParent<DefaultTrackableEventHandler>();
	}
	
	// Update is called once per frame
	void Update () {
        if (doorTrack.IsActive == true&& keyTrack.IsActive == true)
        {
            if (door.active == true)
            {
                float tempD = Vector3.Distance(door.transform.position, key.transform.position);
                if (tempD <= distance)
                {
                    door.SetActive(false);
                }
            }
            else{
                return;
            }
        }
	}
}
