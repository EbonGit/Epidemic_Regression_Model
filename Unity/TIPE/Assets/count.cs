using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count : MonoBehaviour
{
    public int nbrS;
    public int nbrI;
    public int nbrR;
    public int nbrV;
    public bool check = false;
    public GameObject[] objs;
    
    void Start()
    {
        objs = GameObject.FindGameObjectsWithTag("point");
    }

    void Update()
    {
        check = true;
        if (check == true)
        {
            objs = GameObject.FindGameObjectsWithTag("point");
            nbrS = nbrI = nbrR = nbrV = 0;
            foreach (GameObject i in objs)
            {
                bool S = i.GetComponent<SIR>().S;
                bool I = i.GetComponent<SIR>().I;
                bool R = i.GetComponent<SIR>().R;
                bool V = i.GetComponent<SIR>().V;

                if (S == true)
                {
                    nbrS += 1;
                }
                else if (I == true)
                {
                    nbrI += 1;
                }
                else if (V == true)
                {
                    nbrV += 1;
                }
                else
                {
                    nbrR += 1;
                }

            }
            check = false;
        }
    }

}