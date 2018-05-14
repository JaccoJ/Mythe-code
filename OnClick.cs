using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour {

    public void OnMouseDown()
    {
        Application.LoadLevel("Main");
    }

    private void Update()
    {
        if (Input.GetButton("attack"))
        {
            Application.LoadLevel("Main");
        }
        else if (Input.GetMouseButton(0))
        {
            Application.LoadLevel("Main");
        }
    }
}
