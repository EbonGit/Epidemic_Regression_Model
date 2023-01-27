using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIR : MonoBehaviour
{
    public bool S = true;
    public bool I = false;
    public bool R = false;
    public bool V = false;
    public SpriteRenderer sprite;
    public float infectionTime = 3f;
    public float infectionTaux = 0.5f;
    public GameObject[] param;

    public void Infect()
    {
        I = true;
    }

    void Start()
    {
        param = GameObject.FindGameObjectsWithTag("parameter");
        infectionTime = param[0].transform.GetComponent<parameter>().tempsInfection;
        infectionTaux = param[0].transform.GetComponent<parameter>().tauxInfection;

        sprite.color = Color.blue;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "point")
        {
            if (collision.gameObject.GetComponent<SIR>().I == true & R == false & V == false)
            {
                float u = Random.Range(0f, 1f);
                
                if (u <= infectionTaux)
                {
                    I = true;
                    sprite.color = Color.red;
                }
                
            }

        }
    }

    void Update()
    {
        if (I == true)
        {
            S = false;
            R = false;
            sprite.color = Color.red;
            infectionTime -= Time.deltaTime;
            if (infectionTime <= 0)
            {
                I = false;
                R = true;
                
            }
        }

        if (R == true)
        {
            I = false;
            S = false;
            sprite.color = new Color(100,0,100);
        }

        if (V == true)
        {

            I = false;
            R = false;
            S = false;
            sprite.color = new Color(100, 100, 0);
        }

        


    }
}
