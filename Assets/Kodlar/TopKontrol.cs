using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TopKontrol : MonoBehaviour
{
    Rigidbody fizik;
    public int hiz;
    int skor = 0;
    public int toplanacakObjeSayisi;
    public TMP_Text skorText;
    public TMP_Text oyunBittiText;

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay,0,dikey);

        fizik.AddForce(vec*hiz);
    }
    void OnTriggerEnter(Collider other) //temas olup olmadıgını soyluyor. OnTriggerEnter temas olduğu an söylüyor. OnTriggerExit temas bitince söylüyor.
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            skor++;

            skorText.text = "SKOR = " + skor;

            if(skor == toplanacakObjeSayisi)
            {
                oyunBittiText.text = "KAZANDINIZ";
            }

        }
        
    }
}
