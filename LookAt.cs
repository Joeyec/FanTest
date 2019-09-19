
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject camera;
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {


        //当前对象始终面向摄像机。
        this.transform.LookAt(camera.transform.position);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(camera.transform.position - this.transform.position), 0);
    }

}