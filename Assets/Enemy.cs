using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    PuntosScript puntosScript;
    HPScript hpScript;

    // Start is called before the first frame update
    void Start()
    {
        puntosScript = FindObjectOfType<PuntosScript>();
        hpScript = FindObjectOfType<HPScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "jugador")
        {
            hpScript.hp = hpScript.hp - 1;

            if (hpScript.hp <= 0)
            {
                Destroy(collision.gameObject);
            }
        }
        else
        {
            puntosScript.puntos = puntosScript.puntos + 1;
            Destroy(collision.gameObject);

        }

            Destroy(gameObject);
    }
}
