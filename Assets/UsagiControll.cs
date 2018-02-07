using UnityEngine;
using System.Collections;

public class UsagiControll : MonoBehaviour
{
    //アニメーションするためのコンポーネントを入れる
    Animator animator;

    //Usagiを移動させるコンポーネントを入れる
    Rigidbody2D rigid2D;

    // 落下速度の減衰
   // private float dump = 0.1f;

    // 落下速度
    float Velocity = -7;

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
            // 下方向の力をかける
            this.rigid2D.velocity = new Vector2(0, this.Velocity);
        }

        // クリックをやめたら下方向への速度を減速する
/*        if (Input.GetMouseButton(0) == false)
        {
            if (this.rigid2D.velocity.y < 0)
            {
                this.rigid2D.velocity *= this.dump;
            }
            this.rigid2D.velocity = new Vector2(0,0);
        }*/
    }
}
