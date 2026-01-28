using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PuntajeAlto", menuName = "Herramientas/Opciones", order = 0)]
public class Opciones : ScriptableObject
{
    
    public dificultad NivelDificultad = dificultad.facil;


    public enum dificultad
    {
        facil,
        normal,
        dificil
    }

    
    
    public event Action OnDificultadCambiada;

    public void CambiarDificultad(int nuevaDificultad)
    {
        NivelDificultad = (dificultad)nuevaDificultad;
        if (OnDificultadCambiada != null)
            OnDificultadCambiada.Invoke();
    }
}
