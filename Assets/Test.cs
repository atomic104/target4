using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 position;
    // スクリーン座標をワールド座標に変換した位置座標
    private Vector3 screenToWorldPointPosition;
    void Start()
    {
        Console.WriteLine("おは");
    }

    // Update is called once per frame
    void Update()
    {
        position = Input.mousePosition;
        // Z軸修正
        position.z = 10f;
        // マウス位置座標をスクリーン座標からワールド座標に変換する
        screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
        // ワールド座標に変換されたマウス座標を代入
        GameObject.Find("Plane").transform.position = screenToWorldPointPosition;
        GameObject.Find("Cube2").transform.rotation = GameObject.Find("Cube").transform.rotation;
    }
 
}
