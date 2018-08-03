using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{

    public GameObject GehaltenesgameObject;
    public GameObject PlaziertesGamobjectonNode;
    Color startfarbe;


    private void Start()
    {
        GameManagerNodes.instance.Add_Node(this.gameObject);
        startfarbe = this.gameObject.GetComponent<Renderer>().material.color;
        if (GehaltenesgameObject != null&& PlaziertesGamobjectonNode==null)
        {
            PlaziertesGamobjectonNode= Instantiate(GehaltenesgameObject, new Vector3(this.transform.position.x, 1, this.transform.position.z), Quaternion.identity);
        }

    }

    public void neuesGebäude(GameObject Gebäude)
    {
        if (PlaziertesGamobjectonNode!=null)
        {
            //Remove and Replace
            //UI Remove oder id
            GameManagerSkript.instance.GetComponent<GameManagerSkript>().ErrorFürVorhandenesGebäudeUI.gameObject.SetActive(true);

        }
        else
        {
            PlaziertesGamobjectonNode = Instantiate(Gebäude, new Vector3(this.transform.position.x, 1, this.transform.position.z), Quaternion.identity);
        }
       
    }



    public void removeGebäude()
    {
        GameObject.Destroy(PlaziertesGamobjectonNode);
        PlaziertesGamobjectonNode = null;
    }

    private void OnMouseEnter()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.blue;

    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (GameManagerSkript.instance.Get_BuildModeAktive() == true)//IM Buildmodus
        {
            //Aktive Node Anzeigen
            GameManagerSkript.instance.Set_AktiveNode(this.gameObject);
            //UI öffnen
            GameManagerSkript.instance.Activate_Buildmenu();


        }
        else //Im InspectModus
        {

        }
    }

    private void OnMouseExit()
    {
        this.gameObject.GetComponent<Renderer>().material.color = startfarbe;

    }

}
