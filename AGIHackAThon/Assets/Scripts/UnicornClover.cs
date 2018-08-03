﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnicornClover : MonoBehaviour {


    public GameObject obj1;
    public GameObject obj2;

    [SerializeField]
    private float distance = 2.0f;

    private DefaultTrackableEventHandler obj1Track;
    private DefaultTrackableEventHandler obj2Track;

    public GameObject[] effects;

    // Use this for initialization
    void Start()
    {
        obj1Track = obj1.GetComponent<DefaultTrackableEventHandler>();
        obj2Track = obj2.GetComponent<DefaultTrackableEventHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (obj1Track.IsActive == true && obj2Track.IsActive == true)
        {
            float tempD = Vector3.Distance(obj1.transform.position, obj2.transform.position);
            if (tempD <= distance)
            {
                for (int i = 0; i < effects.Length; i++)
                {
                    effects[i].SetActive(true);
                }
            }
            else{
                for (int i = 0; i < effects.Length; i++)
                {
                    effects[i].SetActive(false);
                }
            }
        }
        else{
            for (int i = 0; i < effects.Length; i++)
            {
                effects[i].SetActive(false);
            }
        }

    }
}
