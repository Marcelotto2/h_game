using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    //Statischer Gamemanager
    public static Gamemanager instance;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one Gamemanager in scene!");
            return;
        }
        instance = this;
    }


    private void Update()
    {
        NodeFuntion();

    }

    [Header("---Nodes---")]
    //Nodes
    public GameObject selectedNode;
    public Color Auswahlfarbe;

    public void NodeSelected(GameObject node)
    {
        if (node == null)
        {
            Debug.Log("Keine Selected Node");
            if (selectedNode != null)
            {
                selectedNode.gameObject.GetComponent<node>().Abgewählt();
            }
        }
        else
        {
            if (selectedNode != null)
            {
                if (selectedNode != node)
                {
                    selectedNode.gameObject.GetComponent<node>().Abgewählt();
                }
            }

            Debug.Log("Neue Selected Node -> " + node.name);
        }
        selectedNode = node;
    }

    void NodeFuntion()
    {
        if (selectedNode != null)
        {
            selectedNode.GetComponent<node>().Ausgewählt();
        }
    }
}
