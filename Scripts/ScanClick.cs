using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ScanClick : MonoBehaviour
{
    public GameObject ScanBar;
    public GameObject BeginUI;
    public GameObject camera;
    private void Awake()
    {
        camera.GetComponent<VuforiaBehaviour>().enabled = false;
    }
    public void Show()
    {
         BeginUI.SetActive(false);
        ScanBar.SetActive(true);
        camera.GetComponent<VuforiaBehaviour>().enabled = true;
        Debug.Log("enter");
    }
	
}
