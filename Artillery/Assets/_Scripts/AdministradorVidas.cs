using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AdministradorVidas : MonoBehaviour
{
   
    public TMP_Text textoVidas;
   

    // Start is called before the first frame update
    void Start()
    {
        
        if (textoVidas == null)
        {
            Transform transformVidas = GameObject.Find("Vidas").transform;
            textoVidas = transformVidas.GetComponent<TMP_Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        textoVidas.text = $"Vidas: {AdministradorJuego.DisparosPorJuego}"; 
    }
}
