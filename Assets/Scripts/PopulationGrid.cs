﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PopulationGrid : MonoBehaviour/*, IPointerClickHandler*/
{

    public GameObject[] prefab; // This is our prefab object that will be exposed in the inspector

    //public int numberToCreate; // number of objects to create. Exposed in inspector

    void Start()
    {
        //newObj = new GameObject[numberToCreate];
        Populate();
    }

    void Update()
    {

    }

    //public void OnPointerClick(PointerEventData eventData)
    //{
    //       newObj.GetComponent<Image>().color = Random.ColorHSV();
    //}

    void Populate()
    {
        // Create GameObject instance
        GameObject newObj;

        for (int i = 0; i < /*numberToCreate*/prefab.Length; i++)
        {
            // Create new instances of our prefab until we've created as many as we specified
            newObj = (GameObject)Instantiate(prefab[i], transform);

            // Randomize the color of our image
            newObj.GetComponent<Image>().color = Random.ColorHSV();
        }

    }
}
