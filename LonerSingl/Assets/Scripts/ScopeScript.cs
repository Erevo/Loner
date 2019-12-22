using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeScript : MonoBehaviour
{
    public GameObject myScope;
    private Vector2 mousePos;


    void Start()
    {
        Cursor.visible = false;
    }
    private void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        myScope.transform.position = mousePos;
    }

}
