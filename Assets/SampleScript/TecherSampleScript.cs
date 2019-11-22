using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherSampleScript : MonoBehaviour {
    //このクラスに必要な変数を宣言しよう！
    //float型の変数timerを宣言

    //int型の変数randomNumberを宣言

    //float型の変数resetNumberを宣言

    //bool型の変数timerCheckを宣言

    //bool型の変数resetCheckを宣言

    //float型の変数teacherRotateを宣言


    //ゲームの最初に呼ばれる関数
    void Start() {
        //randomNumberにランダムな値を代入(ヒントは"Random.Range")

        //timerCheckにtrueを代入
    }


    //毎秒呼ばれる関数
    void Update() {
        //teacherRotateにこのGameObjectの回転yの値を入れる


        if (/*もしtimerCheckがtrueなら*/) {

            //timerの値にTime.deltaTimeを加算する
            if (/*timerがrandomNumber以上になったら*/)
            {
                //Turn関数を引数180で呼ぶ
                if (/*techerRotateが1以上なら*/)
                {
                    //Stay関数を呼ぶ
                }
            } else if (/*timerCheckがfalseなら*/)
            {
                //Turn関数を引数0で呼ぶ
                if (/*techerRotateが0以下なら*/)
                {
                    //ChangeBool関数を呼ぶ
                }
            }


        }

    }


    //関数ChangeBoolを作成
    //ChangeBoolのなかで以下実施
    //timerCheckにtrueを代入
    //resetCheckにfalseを代入
    //randomNumberに4~7のランダムな値を代入
    //timerに0を代入


    //関数Stayを作成
    //Stayのなかで以下実施
        if(/*resetCheckがfalseなら*/){
            //resetNumberにランダムに4~6を代入
            //resetNumber秒後に関数Resetを呼ぶ
            //resetCheckにtrueに代入
        }

    //関数Resetを作成
        //timerCheckをfalseを代入

    //関数Turnを作成　引数はfloat型のrotateY
        //stepにTime.deltaTimeを書ける
        //回転させる！！ここはさくに相談！


}
