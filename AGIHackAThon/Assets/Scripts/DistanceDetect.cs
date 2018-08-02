using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDetect : MonoBehaviour {

    public GameObject obj1;
    public GameObject obj2;

    [SerializeField]
    private float distance=2.0f;

    private DefaultTrackableEventHandler obj1Track;
    private DefaultTrackableEventHandler obj2Track;

	// Use this for initialization
	void Start () {
        obj1Track = obj1.GetComponentInParent<DefaultTrackableEventHandler>();
        obj2Track = obj2.GetComponentInParent<DefaultTrackableEventHandler>();
	}
	
	// Update is called once per frame
	void Update () {
        if(obj1Track.IsActive == true && obj2Track.IsActive == true)
        {
            float tempD = Vector3.Distance(obj1.transform.position, obj2.transform.position);
            if(tempD <= distance)
            {
                obj1.transform.Rotate(Vector3.up, 25 * Time.deltaTime);
            }
        }
		
	}
}
