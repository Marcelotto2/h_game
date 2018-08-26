using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class node : MonoBehaviour
{


    private Color startfarbe;
    // Use this for initialization
    void Start()
    {
        startfarbe = this.gameObject.GetComponentInParent<MeshRenderer>().material.color;

    }


    public void Ausgewählt()
    {
        this.gameObject.GetComponentInParent<MeshRenderer>().material.color = Gamemanager.instance.Auswahlfarbe;
    }

    public void Abgewählt()
    {
        this.gameObject.GetComponentInParent<MeshRenderer>().material.color = startfarbe;
    }
}
