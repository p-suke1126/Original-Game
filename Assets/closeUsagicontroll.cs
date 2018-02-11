using UnityEngine;
using System.Collections;

public class closeUsagicontroll : MonoBehaviour
{
    //アニメーションするためのコンポーネントを入れる
    Animator animator;

    //Usagiを移動させるコンポーネントを入れる
    Rigidbody2D rigid2D;

    // 落下速度
    float Velocity = 7;

    private float turnForce = 10;  /// 左右移動の力


    // Use this for initialization
    void Start()
    {
        // アニメータのコンポーネントを取得する
        this.animator = GetComponent<Animator>();
        // Rigidbody2Dのコンポーネントを取得する
        this.rigid2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // クリックされた場合
        if (Input.GetMouseButton(0))
        {
            this.transform.Translate(0, 0, -1);
            this.rigid2D.AddForce(Vector2.down * Velocity, ForceMode2D.Force);
        }
        else if (/*Input.GetMouseButton(1) &&*/ rigid2D.velocity.y < -1f)
        {
            this.transform.Translate(0,0,1);
            this.rigid2D.AddForce(Vector3.up * Velocity, ForceMode2D.Force);
        }

        //usagiを矢印キーに応じて左右に移動させる
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //左に移動
            this.rigid2D.AddForce(Vector2.left * this.turnForce, ForceMode2D.Force);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //右に移動
            this.rigid2D.AddForce(Vector2.right * this.turnForce, ForceMode2D.Force);
        }
    }
}