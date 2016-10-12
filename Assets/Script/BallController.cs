using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    //**************課題用コードＳ*************************************

    private GameObject tokutenText;

    private int tokuten = 0;

    private const int SMALL_STAR_TOKUTEN = 10;

    private const int LARGE_STAR_TOKUTEN = 20;

    private const int SMALL_CLOUD_TOKUTEN = 30;

    private const int LARGE_CLOUD_TOKUTEN = 40;


    //**************課題用コードＥ*************************************

    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        //**************課題用コードＳ*************************************

        this.tokutenText = GameObject.Find("TokutenText");

        //**************課題用コードＥ*************************************
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ){
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

    }

    //**************課題用コードＳ*************************************
    void OnCollisionEnter(Collision other){

        switch (other.gameObject.tag) {
            case "SmallStarTag":
                this.tokuten += SMALL_STAR_TOKUTEN;

                break;
            case "LargeStarTag":
                this.tokuten += LARGE_STAR_TOKUTEN;

                break;
            case "SmallCloudTag":
                this.tokuten += SMALL_CLOUD_TOKUTEN;

                break;
            case "LargeCloudTag":
                this.tokuten += LARGE_CLOUD_TOKUTEN;

                break;
            default:
                break;
        }

        this.tokutenText.GetComponent<Text>().text = "SCORE:" + this.tokuten;
    }
    //**************課題用コードＥ*************************************
}