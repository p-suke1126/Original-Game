using UnityEngine;
using System.Collections;

public class CameraControll : MonoBehaviour
{
    //Usagiのオブジェクト
    private GameObject usagi;
    //Usagiとカメラの距離
//    private Vector3 difference;
    private float difference;

    // Use this for initialization
    void Start()
    {
        //Usagiのオブジェクトを取得
        this.usagi = GameObject.Find("usagi2");
        //Usagiとカメラの位置（y座標）の差を求める
        this.difference = usagi.transform.position.y - this.transform.position.y;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position.y > -30f)
        {
            //Usagiの位置に合わせてカメラの位置を移動
            this.transform.position = new Vector3(0, usagi.transform.position.y - difference,-10);
        }
    }
}
