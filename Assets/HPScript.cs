using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HPScript : MonoBehaviour
{
    public int hp;

    private TMP_Text textCompoennt;
    void Start()
    {
        textCompoennt = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textCompoennt.text = "Vidas: " + hp;
    }
}
