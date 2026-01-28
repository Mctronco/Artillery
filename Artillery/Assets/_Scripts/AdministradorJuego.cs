using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorJuego : MonoBehaviour
{
    public static AdministradorJuego SingletonAdministradorJuego;
    public static int VelocidadBala = 30;
    public static int DisparosPorJuego = 10;
    public static float VelociadRotacion = 1;
    public bool juegoTerminado = false;

    public GameObject CanvasGanar;
    public GameObject CanvasPerder;

    public Opciones opciones;

    void Start()
    {
        if (opciones != null)
        {
            opciones.OnDificultadCambiada += ActualizarDisparosPorJuego;
        }
        ActualizarDisparosPorJuego();
    }
    void ActualizarDisparosPorJuego()
    {
        if (opciones.NivelDificultad == Opciones.dificultad.facil)
            DisparosPorJuego = 10;
        else if (opciones.NivelDificultad == Opciones.dificultad.normal)
            DisparosPorJuego = 8;
        else
            DisparosPorJuego = 5;
    }

    private void Awake()
    {
        if (SingletonAdministradorJuego == null)
        {
            SingletonAdministradorJuego = this;
        }
        else
        {
            Debug.LogError("Ya existe una intsancia de esta clase");
        }
    }

    private void Update()
    {
        if (juegoTerminado) return;

        if (DisparosPorJuego < 0)
        {
            PerderJuego();
        }
    }

    public void GanarJuego()
    {
        
        CanvasGanar.SetActive(true);
    }

    public void PerderJuego()
    {
        
        CanvasPerder.SetActive(true);
    }
}
