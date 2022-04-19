using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string contraseniacorrecta;
    string contraseniausuario;
    public Text ingresousuario;
    public Text textomsj;
    public GameObject cartelitomsj;
    // Start is called before the first frame update
    void Start()
    {
        contraseniacorrecta = "12345";
        cartelitomsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarcontrasenia()
    {
        contraseniausuario = ingresousuario.text;
        if (contraseniausuario == contraseniacorrecta)
        {
            cartelitomsj.SetActive(true);
            textomsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitomsj.SetActive(true);
            textomsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
}
