using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit;
using HoloToolkit.Unity.InputModule;
public class ItemManager : MonoBehaviour {
    public GameObject[] objectsToPlace;
    public int currentPlacement = -1;
    public List<GameObject> placedObjects = new List<GameObject>();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        objectPlaced();
	}
    void objectPlaced()
    {
        for (int i = 0; i < objectsToPlace.Length;i++)
        {
            if (objectsToPlace[i].GetComponentInChildren<TapToPlace>().IsBeingPlaced == true)
            {

                objectsToPlace[i].GetComponent<ItemStats>().hasBeenUsed = true;
                currentPlacement++;
                objectsToPlace[i].GetComponent<ItemStats>().OrderOfPlacement(currentPlacement);
                placedObjects.Add(objectsToPlace[i]);


            }
        }

    }
    
}
