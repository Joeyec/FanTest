using HoloToolkit.Unity.UX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCtr : MonoBehaviour
{
    public GameObject Fan;
    public int step = 2;
    //private void Start()
    //{
    //    GameObject.Find("AppBar(Clone)").GetComponent<AppBar>().HoverOffsetZ = -0.8f;
    //}
    public void Shunshizhen()
    {
        InvokeRepeating("Shun", 0, 0.2f);
        
    
            // if (Input.GetButtonDown(GameObject.FindGameObjectWithTag("shunshizhen").name))
           // Fan.transform.Rotate(new Vector3(0, step, 0));
            
        
    }
    public void StopShun()
    {

        CancelInvoke("Shun");
    }
    public void Shun()
    {
        Fan.transform.Rotate(new Vector3(0, step, 0));
    }
    public void Nishizhen()
    {
        //if(Input.GetButtonDown(GameObject.FindGameObjectWithTag("nishizhen").name))
        InvokeRepeating("Ni", 0, 0.2f);
    }
    public void StopNi()
    {
        CancelInvoke("Ni");
    }
    public void Ni()
    {
        Fan.transform.Rotate(new Vector3(0, -step, 0));
    }
}
