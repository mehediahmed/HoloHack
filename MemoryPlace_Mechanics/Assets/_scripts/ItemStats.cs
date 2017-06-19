using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStats : MonoBehaviour {

    public bool hasBeenUsed = false;
    public string name;
    public int indexOfPlacement = -1;
    private void Awake()
    {
        name = gameObject.name;
    }
    public void OrderOfPlacement(int newIndex)
    {
        indexOfPlacement = newIndex;

    }
}
