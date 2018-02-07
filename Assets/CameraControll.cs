using UnityEngine;
using System.Collections;

public class CameraControll : MonoBehaviour
{
    //Usagiのオブジェクト
    private GameObject usagi;
    //Usagiとカメラの距離
    private Vector3 difference;

    // Use this for initialization
    void Start()
    {
        //Usagiのオブジェクトを取得
        this.usagi = GameObject.Find("usagi2");
        //Usagiとカメラの位置（z座標）の差を求める
        this.difference = this.transform.position - usagi.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Usagiの位置に合わせてカメラの位置を移動
        this.transform.position = usagi.transform.position + difference;
    }
}
