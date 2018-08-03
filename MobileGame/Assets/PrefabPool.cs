using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabPool : MonoBehaviour {

    //Statischer PrefabPool
    public static PrefabPool instance;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one PrefabPool in scene!");
            return;
        }
        instance = this;
    }

    public List<prefab_skript> Pool;


}
