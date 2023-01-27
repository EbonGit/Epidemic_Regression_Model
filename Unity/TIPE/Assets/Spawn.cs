using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public int nbr = 1;
    public float vaccin;
    public float quarantaine;
    public Transform prefab;
    public Transform prefabV;
    public Transform prefabQ;
    public float spawnX;
    public float spawnY;
    public Transform mur;
    public GameObject[] param;

    


    void Start()
    {

        param = GameObject.FindGameObjectsWithTag("parameter");
        nbr = param[0].transform.GetComponent<parameter>().nbrInstance;
        vaccin = param[0].transform.GetComponent<parameter>().prcVaccin;
        quarantaine = param[0].transform.GetComponent<parameter>().prcQuarantaine;

        int nbrV = (int) (vaccin * nbr);
        int nbrQ = (int)(quarantaine * nbr);

        for (int i = 0; i < nbr-nbrV-nbrQ; i++)
        {
            spawnX = gameObject.transform.position.x + (Random.Range(-4f, 4f)) * mur.transform.localScale.x;
            spawnY = gameObject.transform.position.y + (Random.Range(-4f, 4f)) * mur.transform.localScale.y;

            Transform ekip = Instantiate(prefab);
            ekip.transform.parent = gameObject.transform;
            ekip.transform.position = new Vector3(spawnX, spawnY, 0);
        }


        for (int i = 0; i < nbrQ; i++)
        {
            spawnX = gameObject.transform.position.x + (Random.Range(-4f, 4f)) * mur.transform.localScale.x;
            spawnY = gameObject.transform.position.y + (Random.Range(-4f, 4f)) * mur.transform.localScale.y;

            Transform ekip = Instantiate(prefabQ);
            ekip.transform.parent = gameObject.transform;
            ekip.transform.position = new Vector3(spawnX, spawnY, 0);
        }



        for (int i = 0; i < nbrV; i++)
        {
            spawnX = gameObject.transform.position.x + (Random.Range(-4f, 4f)) * mur.transform.localScale.x;
            spawnY = gameObject.transform.position.y + (Random.Range(-4f, 4f)) * mur.transform.localScale.y;

            Transform ekip = Instantiate(prefabV);
            ekip.transform.parent = gameObject.transform;
            ekip.transform.position = new Vector3(spawnX, spawnY, 0);
        }
    }

}
