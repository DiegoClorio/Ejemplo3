using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntosScript : MonoBehaviour
{
    public TMP_Text textComponent;

    public int puntos = 0;

    void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = "Puntos: " + puntos;
    }
}
