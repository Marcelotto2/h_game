using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSkript : MonoBehaviour
{

    //Statischer GameManagerSkript
    public static GameManagerSkript instance;
    public GameObject Buildmenu;
    public Transform CameraOldPosition;
    public GameObject AktiveNode;
    public GameObject ErrorFürVorhandenesGebäudeUI;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one GameManagerSkript in scene!");
            return;
        }
        instance = this;
    }

    //Variabeln
    bool BouildMode = false;

    // Use this for initialization
    void Start()
    {
        if (Buildmenu != null)
        {
            Buildmenu.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogError("Kein Buildmenu im Gamemanager Verknüpft");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void Set_AktiveNode(GameObject aktivenode)
    { AktiveNode = aktivenode; }



    public void Activate_Buildmenu()
    {
        Buildmenu.gameObject.SetActive(true);
    }

    public void Deactivate_Buildmenu()
    {
        Buildmenu.gameObject.SetActive(false);
    }

    //BuildModes:

    public bool Get_BuildModeAktive()
    {
        Time.timeScale = 0;
        return BouildMode;
    }
    public void BuildModeON()
    {

        BouildMode = true;
    }
    public void BuildModeOFF()
    {
        Time.timeScale = 1;
        BouildMode = false;
    }


    //-----BuildingMeneu-----
    public void BuildObject()
    {
        GameObject nodego = GameManagerSkript.instance.AktiveNode;
        if (nodego != null)
        {
            nodego.gameObject.GetComponent<Node>().neuesGebäude(BaueAufNode);
        }
        else
        {
            nodego.gameObject.GetComponent<Node>().removeGebäude();
        }

    }

    public void ReplaceOnActiveNode()
    {
        GameManagerSkript.instance.AktiveNode.gameObject.GetComponent<Node>().removeGebäude();
        GameManagerSkript.instance.AktiveNode.gameObject.GetComponent<Node>().neuesGebäude(BaueAufNode);
    }

    public GameObject BaueAufNode;

    public GameObject Mauer;
    public void build_Mauer()
    {
        if (Mauer != null)
        {
            BaueAufNode = Mauer;
            BuildObject();
        }
        else
        {
            Debug.LogError("Keine zuweißung zum bauen");
        }
    }

    public void build_Remove()
    {
        BaueAufNode = null;
        GameManagerSkript.instance.AktiveNode.gameObject.GetComponent<Node>().removeGebäude();
    }
}
