using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCube : MonoBehaviour
{
    void OnTouchDown()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.magenta;
    }
    void OnTouchUp()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.red;

    }
    void OnTouchStay()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.clear;

    }
    void OnTouchExit()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.cyan;

    }

}
