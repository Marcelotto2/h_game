using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerNodes : MonoBehaviour
{

    //Statischer GameManagerNodes
    public static GameManagerNodes instance;
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one GameManagerNodes in scene!");
            return;
        }
        instance = this;
    }

    //Node Liste
    public List<GameObject> Nodes;

    public void Add_Node(GameObject node)
    {
        Nodes.Add(node);
        Debug.Log("Node added" + node.name);
    }
    //BigNode
    public GameObject BigNode;

    public void Add_BigNode(GameObject bignode)
    {
        BigNode = bignode;
        Debug.Log("BigNode added" + bignode.name);
    }


}
