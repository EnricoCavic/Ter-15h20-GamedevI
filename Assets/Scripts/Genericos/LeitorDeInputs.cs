using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeitorDeInputs
{
    // variáveis
    public Vector2 inputVector;
    public bool jumpInput;    

    // construtor (ocorre quando uma instancia nova é criada)
    public LeitorDeInputs()
    {
        inputVector = new Vector2();
    }
    

    // funções (ações)
    public void RegistrarInputs()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");
        jumpInput = Input.GetKey(KeyCode.Space);
    }

}


