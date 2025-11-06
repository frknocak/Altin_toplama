using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public bool oyunAktif = true;
    public int altinSayisi = 0;
    public UnityEngine.UI.Text altinsayisiText;
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AltinArttir()
    {
        altinSayisi += 1;
        altinsayisiText.text = "" + altinSayisi;
    }
}
