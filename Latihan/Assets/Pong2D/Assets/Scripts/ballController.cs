using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballController : MonoBehaviour
{
    public int force;
    Rigidbody2D rigid;
    int scoreP1;
    int scoreP2;
    Text scoreUIP1;
    Text scoreUIP2;
    GameObject panelSelesai;
    public Text txP1Win;
    public Text txP2Win;
    AudioSource audio;
    public AudioClip hitSound;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        Vector2 arah = new Vector2(-2, 0).normalized;
        rigid.AddForce(arah* force);
        scoreP1 = 0;
        scoreP2 = 0;
        scoreUIP1 = GameObject.Find("score1").GetComponent<Text>();
        scoreUIP2 = GameObject.Find("score2").GetComponent<Text>();
        panelSelesai = GameObject.Find("panelSelesai");
        panelSelesai.SetActive(false);
        audio = GetComponent<AudioSource>();
    }
    
    void Update()
    {

    }
    
    private void OnCollisionEnter2D(Collision2D coll)
    {
        audio.PlayOneShot(hitSound);
        if (coll.gameObject.name == "tepiKanan")
        {
            scoreP1 += 1;
            TampilkanScore();
            ResetBall();
            Vector2 arah = new Vector2(2, 0).normalized;
            rigid.AddForce(arah * force);
        }
        if (coll.gameObject.name == "tepiKiri")
        {
            scoreP2 += 1;
            TampilkanScore();
            ResetBall();
            Vector2 arah = new Vector2(-2, 0).normalized;
            rigid.AddForce(arah * force);
        }
        if (coll.gameObject.name == "pemain1" || coll.gameObject.name == "pemain2")
        {
            float sudut = (transform.position.y - coll.transform.position.y) * 5f;
            Vector2 arah = new Vector2(rigid.velocity.x, sudut).normalized;
            rigid.velocity = new Vector2(0, 0);
            rigid.AddForce(arah * force * 2);
        }
    }
    
    void ResetBall()
    {
        transform.localPosition = new Vector2(0, 0);
        rigid.velocity = new Vector2(0, 0);
    }
    
    void TampilkanScore()
    {
        Debug.Log("score P1: " + scoreP1 + " score P2: " + scoreP2);
        scoreUIP1.text = scoreP1 + "";
        scoreUIP2.text = scoreP2 + "";
        if (scoreP1 == 5)
        {
            panelSelesai.SetActive(true);
            txP1Win.text = "player 1 win!";
            txP2Win.text = "";
            Destroy(gameObject);
            return;
        }
        if (scoreP2 == 5)
        {
            panelSelesai.SetActive(true);
            txP1Win.text = "";
            txP2Win.text = "player 2 win!";
            Destroy(gameObject);
            return;
        }
    }
}