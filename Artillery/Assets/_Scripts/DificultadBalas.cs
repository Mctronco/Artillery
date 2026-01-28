using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DificultadBalas : MonoBehaviour
{
    public Opciones opciones;
    public int DisparosPorJuego;
    

    // Start is called before the first frame update
    void Start()
    {
        if (opciones != null)
        {
            opciones.OnDificultadCambiada += ActualizarDisparosPorJuego;
            ActualizarDisparosPorJuego();
        }
    }

    void ActualizarDisparosPorJuego()
    {
        if (opciones.NivelDificultad == Opciones.dificultad.facil)
            DisparosPorJuego = 10;
        else if (opciones.NivelDificultad == Opciones.dificultad.normal)
            DisparosPorJuego = 8;
        else
            DisparosPorJuego = 3;
    }
}

 

