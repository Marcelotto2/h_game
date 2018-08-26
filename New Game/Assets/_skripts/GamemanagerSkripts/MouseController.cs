using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseController : MonoBehaviour
{

    public float rayLenght;
    public LayerMask layermask;

    private void Start()
    {
        //GetUnderMouse();
        InvokeRepeating("GetUnderMouse", 0f, 0.05f);
    }

    private void Update()
    {
        //GetUnderMouse();

        ButtomPressed();
    }


    void GetUnderMouse()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, rayLenght, layermask))
            {
                Gamemanager.instance.NodeSelected(hit.collider.gameObject);
                Debug.Log(hit.collider.name);
            }
            else
            {
                Gamemanager.instance.NodeSelected(null);
            }
        }
    }

    void ButtomPressed()
    {
        if (Input.GetKeyDown("mouse 0")&&Gamemanager.instance.selectedNode!=null)
        {
            Debug.Log("Leftklick!!!");
            GameObject node = Gamemanager.instance.selectedNode;

        }
    }

}
