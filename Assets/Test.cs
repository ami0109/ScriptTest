using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //配列を初期化する
        int[] array = { 10, 20, 30, 60, 50 };

        //配列の要素の分だけ処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {
            //配列の要素を表示する
            Debug.Log(array[i]);

        }

        //逆順で配列の要素の分だけ処理を繰り返す
        for (int i = array.Length-1; i>=0; i--)
        {
            //配列の要素を表示する
            Debug.Log(array[i]);

        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();


        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        //Magic関数を呼び出して、魔法を使う
        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }
        lastboss.Magic();
    }

}

public class Boss
{
    private int hp = 100;  // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //mp

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    //mpを消費して魔法攻撃をするMagic関数
    public void Magic()
    {           
        if (mp >= 5) {
            this.mp -= 5;
            Debug.Log( "魔法攻撃をした。残りMPは"+mp ); }
        else { Debug.Log("MPが足りないため魔法が使えない。"); }
        
    }


}
