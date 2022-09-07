using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KarakterControl : MonoBehaviour
{
    public float Saglik;
   
    public GameObject canbari;
    public GameObject menupaneli;
    public Text cantext;
    private int caninti;
    public GameObject azcan;
    public Image Joystickgizletmek;


    
    void Start()
    {
        Saglik = 100;
        Time.timeScale = 1;
    }

    
    void Update()
    {
        Joystickgizletmek.enabled = true;
        //Time.timeScale = 1;
        canbari.transform.localScale = new Vector3(Saglik / 100, 1, 1);
        if (Saglik > 100)
        {
            Saglik = 100;
        }
        if(Saglik <= 0)
        {
            Saglik = 0;
            menupaneli.SetActive(true);
            Joystickgizletmek.enabled = false;

            Time.timeScale = 0;
        }
        else if (Saglik <= 45)
        {
            azcan.SetActive(true);

        }
        else
        {
            azcan.SetActive(false);

        }
        caninti = (int)Saglik;
        cantext.text = caninti.ToString();
    }
    public void SaglikDurumu(float Darbegucu)
    {
        Saglik -= Darbegucu;
        Debug.Log(Saglik);
        if(Saglik <= 0)
        {
            Debug.Log("GG");
        }
    }
}
