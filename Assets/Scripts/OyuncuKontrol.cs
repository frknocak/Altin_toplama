using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    public AudioClip altin, dusme;
    private float hiz = 10f;
    public OyunKontrol oyunK;
    void Start()
    {
        
    }

    void Update()
    {
        if (oyunK.oyunAktif)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            x *= Time.deltaTime * hiz;
            y *= Time.deltaTime * hiz;

            transform.Translate(x, 0f, y);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("altin"))
        {
            AudioSource.PlayClipAtPoint(altin, transform.position);
            oyunK.AltinArttir();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag.Equals("dusman"))
        {
            AudioSource.PlayClipAtPoint(dusme, transform.position);
            oyunK.oyunAktif = false;
        }
    }
}
