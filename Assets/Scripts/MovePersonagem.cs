// bibliotecas/libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovePersonagem : MonoBehaviour
{
    /*
    //tipagem F O R T E
    string nome = "Enrico Cavicchioli";
    uint idade = 25;
    float altura = 1.84f;
    bool gosta_de_cafe = true; //OMEGA TRUE
    */

    Vector2 inputVector;
    bool jumpInput;

    public float velocidadeMovimento = 20f;
    public float forcaPulo = 5f;

    Rigidbody meuRb;
    BoxCastManager castManager;

    void Start()
    {
        Initialize();
    }

    // função é chamada uma vez por frame (fps)
    void Update()
    {
        RegistrarInputs();
    }


    // usar fixed para aplicar movimento
    void FixedUpdate()
    {
        Mover();
        TentarPular();       
    }  

    void Initialize()
    {
        // cache de informação
        // inicialização
        meuRb = GetComponent<Rigidbody>();
        castManager = GetComponent<BoxCastManager>();
        inputVector = new Vector2();        
    }

    void RegistrarInputs()
    {
        // registro de inputs
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");
        jumpInput = Input.GetKey(KeyCode.Space);
    }

    void Mover()
    {
        // movimentando
        Vector3 dir = new Vector3(inputVector.x, 0, inputVector.y);
        meuRb.AddForce(dir * velocidadeMovimento , ForceMode.Force);
    }

    void TentarPular()
    {
        // pulo 
        if( jumpInput && castManager.CheckCast("Ground") )
        {
            meuRb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
        }
    }

}
