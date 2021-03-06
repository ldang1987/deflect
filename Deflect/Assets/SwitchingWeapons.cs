﻿using UnityEngine;
using System.Collections;

public class SwitchingWeapons : MonoBehaviour {

    [SerializeField]
    private GameObject[] arrayOfSwords;
    private int count;
    private GameObject currentActive;

	// Use this for initialization
	void Start () {
        count = 0;
        if(arrayOfSwords.Length < 1)
        {
            Debug.Log("Need at least one sword");
            Destroy(gameObject);
        }
        else
        {
            currentActive = arrayOfSwords[0];
            currentActive.SetActive(true);
        }
        CheckCount();
	}
	
	// Update is called once per frame
	void Update () {


        if (SteamVR_Controller.Input(2).GetPressDown(SteamVR_Controller.ButtonMask.Grip)
            || Input.GetKeyDown("z"))
        {
            //Debug.Log("press grip");
            if(arrayOfSwords.Length > 0)
            {
                currentActive.SetActive(false);
                arrayOfSwords[count].SetActive(true);
                currentActive = arrayOfSwords[count];
                count++;
                Debug.Log("SWITCHING WEAPONS!!!");
            }
            CheckCount();
        }

    }

    void CheckCount()
    {
        if(count >= arrayOfSwords.Length)
        {
            count = 0;
        }
    }
}
