using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;

public class parameter : MonoBehaviour
{
    public int nbrInstance; //le nombre de point par ville entre 1 et 250
    public float prcVaccin; //le pourcentage de point vacciné entre 0 et 1
    public float prcQuarantaine; //le pourcentage de point qui applique la quanrantaine entre 0 et (1 - prcVaccin)
    public float tauxInfection; //pourcentage de chance de transmettre la maladie par contact entre 0 et 1
    public float tempsInfection; //durée du stade infection entre 0 et 100
    public float tempsQuarantaine; //temps pour mettre le point en quarantaine entre 0 et tempsInfection
    public float tempsVoyage; //durée entre chaque voyage de point entre deux ville entre 0 et 100

    public string path;

    private bool debut;
    public GameObject count;

    void Update()
    {
        var path_ = Application.dataPath + "/log.csv";


        count = GameObject.FindGameObjectsWithTag("count")[0];
       
        if (debut == false && count.transform.GetComponent<count>().nbrI != 0)
        {
            debut = true;
        }

        if (debut == true)
        {
            if (count.transform.GetComponent<count>().nbrI == 0)
            {
                int a = count.transform.GetComponent<count>().nbrR;

                var pack = a.ToString() + ";" + nbrInstance.ToString() + ";" + prcVaccin.ToString() + ";" + prcQuarantaine.ToString() + ";" + tauxInfection.ToString() + ";" + tempsInfection.ToString() + ";" + tempsQuarantaine.ToString() + ";" + tempsVoyage.ToString();


                if (File.Exists(path_))
                {
                    Debug.Log("oui");
                }

                StreamWriter writer = new StreamWriter(path_, true);
                writer.WriteLine(pack);
                writer.Flush();
                writer.Close();
                StreamReader strReader = new StreamReader(path_);
                Debug.Log(strReader.ReadToEnd());

                


                //var sw = new StreamWriter(Application.dataPath + "log.csv", true);

                //sw.WriteLine("a");

                //sw.Close();
                //File.AppendAllText(Application.dataPath + "log.csv", "a");
                debut = false;
            }
        }

    }





    void Awake()
    {
        path = Application.dataPath + "/data.csv";


        if (File.Exists(path))
        {
            
            StreamReader strReader = new StreamReader(path);
            bool endOfFile = false;
            while (!endOfFile)
            {
                string data_string = strReader.ReadLine();
                if (data_string == null)
                {
                    endOfFile = true;
                    break;
                }
                print(data_string);
                var data_values = ((data_string.Replace(",", ";")).Replace(".", ",")).Split(';');
                
                foreach(string str in data_values)
                {
                    print(str);
                }


                nbrInstance = int.Parse(data_values[0]);
                prcVaccin = float.Parse(data_values[1]);
                prcQuarantaine = float.Parse(data_values[2]);
                tauxInfection = float.Parse(data_values[3]);
                tempsInfection = float.Parse(data_values[4]);
                tempsQuarantaine = float.Parse(data_values[5]);
                tempsVoyage = float.Parse(data_values[6]);
            }
        }
    }

}
