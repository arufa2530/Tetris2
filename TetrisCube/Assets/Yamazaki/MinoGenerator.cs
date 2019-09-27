using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinoGenerator : MonoBehaviour
{
    GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        // CubeプレハブをGameObjent型で取得
        obj = (GameObject)Resources.Load("Prefubs/Cube(I)");
        // Cubeプレハブを元に、インスタントを生成
        Instantiate(obj, new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
