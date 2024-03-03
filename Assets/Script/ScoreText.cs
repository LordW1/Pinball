using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TMP_Text MyscoreText;
    public TMP_Text lifecount;
    public int life;
    public int ScoreNum;

    public AudioSource Rock;
    public AudioSource Catch;
    public AudioSource Gunshot;
    public AudioSource Rope;
    public AudioSource Flip;

    

    //string currentSceneName = SceneManager.GetActiveScene().name;
    // Start is called before the first frame update
    void Start()
    {

        ScoreNum = 0;
        life = 3;
        MyscoreText.text = "Score: " + ScoreNum;
        lifecount.text = "Life: "+ life;
        this.transform.position = new Vector3(0,0,0);

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {

            ScoreNum++;
            MyscoreText.text = "Score: " + ScoreNum;
            Catch.Play();


        }
        
          if (collision.gameObject.CompareTag("Flip"))
        {

            Flip.Play();


        }

           if (collision.gameObject.CompareTag("rock"))
        {

            Rock.Play();


        }

            if (collision.gameObject.CompareTag("rope"))
        {

            Rope.Play();


        }


         if (collision.gameObject.CompareTag("Death"))
        {
            life--;

            if(life > 0){

             lifecount.text = "Life: "+ life;
             this.transform.position = new Vector3(0,0,0);
             Gunshot.Play();

            } else if (life <= 0){

                lifecount.text = "Restart: R";
                Gunshot.Play();
                

            }

        }


    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Start();
        }
        
    }
}
