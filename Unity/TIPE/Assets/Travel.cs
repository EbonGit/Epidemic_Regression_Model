using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Travel : MonoBehaviour
{

    
    public List<Transform> city;
    public List<int> oxi;
    public List<Transform> target;
    public List<Vector3> targetPos;
    public float TravelTime;
    public float timeLeft;
    public GameObject[] param;
    

    void GetTarget()
    {
        target.Clear();
        targetPos.Clear();
        foreach (Transform ici in city)
        {
            Transform spawner = ici.GetChild(0);
            int b = spawner.childCount;
            target.Add(spawner.GetChild(Random.Range(0, b - 1)));
        }
        for (int j = 0; j < target.Count; j++)
        {
            targetPos.Add(new Vector3(target[j].position.x, target[j].position.y, target[j].position.z));
        }
    }



    void Start()
    {
        param = GameObject.FindGameObjectsWithTag("parameter");
        TravelTime = param[0].transform.GetComponent<parameter>().tempsVoyage;

        int a = gameObject.transform.childCount;
        
        for (int i = 0; i < a; ++i)
        {
            city.Add(gameObject.transform.GetChild(i));
        }

        
       // foreach (Transform ici in city)
       // {
       //     print(ici.name);
       //     Transform spawner = ici.GetChild(0);
       //     int b = spawner.childCount;
        //    oxi.Add(b);
        //    target.Add(spawner.GetChild(Random.Range(0, b - 1)));
        //}

        for(int j=0; j < target.Count; j++)
        {
            targetPos.Add(new Vector2(target[j].position.x, target[j].position.y));
        }
    }

    void Update()
    {







        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            
            //shuffle
            for (int i = 0; i < targetPos.Count-1; i++)
            {
                Vector3 temp = targetPos[i];
                int randomIndex = Random.Range(i, targetPos.Count);
                targetPos[i] = targetPos[randomIndex];
                targetPos[randomIndex] = temp;
            }

            //swape
            for (int i = 0; i < target.Count; i++)
            {
                target[i].position = targetPos[i];
            }

            //reload
            GetTarget();


            timeLeft += TravelTime;
        }
    }
}
