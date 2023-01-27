using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ekip : MonoBehaviour
{
    public bool active = false;
    public Transform moi;
    public bool infected;
    public float delta;
    public float timeLeft;
    public bool where = false;
    public Vector3 go;
    public Vector3 back;
    public SpriteRenderer sprite;
    public GameObject[] param;

    // Start is called before the first frame update
    void Start()
    {
        param = GameObject.FindGameObjectsWithTag("parameter");
        delta = param[0].transform.GetComponent<parameter>().tempsQuarantaine;
        
        moi = this.gameObject.transform;
        timeLeft = delta;
        if (active == true)
        {
            sprite.color = Color.green;
        }

    }

    // Update is called once per frame
    void Update()
    {
        infected = moi.GetComponent<SIR>().I;

        if (active == true)
        {
            if (infected == true & where == false)
            {
                timeLeft -= Time.deltaTime;
                if (timeLeft <= 0)
                {
                    back = moi.position;
                    moi.position = go;
                    where = true;

                    timeLeft += delta;
                }
            }

            if (where == true & moi.GetComponent<SIR>().R == true)
            {
                where = false;
                moi.position = back;

            }
        }

    }
}
