using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeColor : MonoBehaviour {

    private Color originalColor;
    private Vector3 originalVector;

    // Use this for initialization
    void Start()
    {

        var newColor = new Color(1.0f, 0.92f, 0.016f, 1.0f);
        this.GetComponent<Renderer>().material.color = newColor;

        originalColor = newColor;
        originalVector = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnSelect()
    {
        var cube = this.GetComponent<Renderer>();

        cube.material.color = Color.magenta;
    }

    void OnReset()
    {
        var cube = this.GetComponent<Renderer>();

        cube.material.color = originalColor;
    }

    public void OnResetBlock() {
        this.transform.position = originalVector;
    }

}


