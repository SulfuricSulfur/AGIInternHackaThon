using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStarsEnabled : MonoBehaviour {


    public GameObject target;
    public GameObject targetParent;
    private DefaultTrackableEventHandler targetTrack;

    public GameObject[] stars;
    public GameObject parentStar;
    private DefaultTrackableEventHandler starsTrack;
    public GameObject spawnPosition;

    // Use this for initialization
    void Start()
    {
        //target = targetGame.transform;
        targetTrack = targetParent.GetComponent<DefaultTrackableEventHandler>();
        starsTrack = parentStar.GetComponent<DefaultTrackableEventHandler>();
    }

    // Update is called once per frame
    void Update()
    {


        if (starsTrack.IsActive == true && targetTrack.IsActive == true)
        {
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].SetActive(true);
                stars[i].transform.parent = null;
            }
        }

        else if (targetTrack.IsActive == false)
        {
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].transform.SetParent(parentStar.transform);
                stars[i].SetActive(false);
                stars[i].transform.position = spawnPosition.transform.position;
            }

        }
        /*
        else if (starsTrack.IsActive == false)
        {
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].transform.SetParent(parentStar.transform);
                stars[i].SetActive(false);
                stars[i].transform.position = spawnPosition.transform.position;
            }
        }
        */



    }


}

