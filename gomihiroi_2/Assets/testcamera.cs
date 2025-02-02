﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testcamera : MonoBehaviour
{
    GameObject targetObj;
    Vector3 targetPos;
    public float CameraSpeed;

    void Start()
    {
        targetObj = GameObject.Find("SD_unitychan_humanoid");
        targetPos = targetObj.transform.position;
    }

    void Update()
    {
        // targetの移動量分、自分（カメラ）も移動する
        transform.position += targetObj.transform.position - targetPos;
        targetPos = targetObj.transform.position;

        //// マウスの右クリックを押している間
        //if (Input.GetMouseButton(1))
        //{
        //    // マウスの移動量
        //    float mouseInputX = Input.GetAxis("Mouse X");
        //    // targetの位置のY軸を中心に、回転（公転）する
        //    transform.RotateAround(targetPos, Vector3.up, mouseInputX * Time.deltaTime * 200f);
        //}
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(targetPos, Vector3.up, CameraSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(targetPos, Vector3.up, -CameraSpeed * Time.deltaTime);
        }
    }
}