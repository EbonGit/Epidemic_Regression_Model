using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Infected : MonoBehaviour
{

    public GameObject[] objs;
    public int nbrinf = 1;
    private bool fait = false;

    void Awake()
    {
        // objs = GameObject.FindGameObjectsWithTag("point");
        // infection();
        Time.timeScale = 2;
    }

    void infection()
    {
        int a = objs.Length;
        int r = Random.Range(0, a - 1);
        bool S = objs[r].GetComponent<SIR>().S;


        if (S == true)
        {
            objs[r].GetComponent<SIR>().Infect();
            print("add " + nbrinf + " infected");
            nbrinf++;
        }
        else
        {
            infection();
        }
    }

    void Update()
    {
        if (objs.Length != 0 && fait == false)
        {
            infection();
            fait = true;
        }
        objs = GameObject.FindGameObjectsWithTag("point");
        if (Input.GetKeyDown("i"))
        {
            
            infection();
            


        }
        if (Input.GetKeyDown("r"))
        {

            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);



        }
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown("g"))
        {


            Time.timeScale = 1;



        }
    }
}
