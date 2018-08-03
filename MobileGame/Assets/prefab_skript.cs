using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefab_skript : MonoBehaviour {

    static int index = 0;

    //Costen des Objectes
    public int Geld = 100;

    public GameObject AktuellesGameobject;
    public List<GameObject> GameObjects;

    public GameObject WähleAus()
    {
        return GameObjects[index];
    }

    public void NextIndex()
    {
        if (index+1>=GameObjects.Capacity)
        {
            index = 0;
        }
        else
        {
            index = index + 1;
        }
        AktuellesGameobject = GameObjects[index];
    }

    public void PreviusIndex()
    {
        if (index-1<0)
        {
            index = GameObjects.Capacity - 1;
        }
        else
        {
            index = index - 1;
        }
        AktuellesGameobject = GameObjects[index];
    }

}
