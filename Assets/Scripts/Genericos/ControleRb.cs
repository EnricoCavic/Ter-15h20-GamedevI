using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleRb
{
    // declaração de variáveis
    Rigidbody meuRb;
    BoxCastManager castManager;

    // construtor com parâmetros
    public ControleRb(Rigidbody _rb, BoxCastManager _mg)
    {
        // guardando informação
        meuRb = _rb;
        castManager = _mg;
    }

    public void Mover(Vector2 _inputVector, float _velocidadeMovimento)
    {
        // movimentando
        Vector3 dir = new Vector3(_inputVector.x, 0, _inputVector.y);
        meuRb.AddForce(dir * _velocidadeMovimento , ForceMode.Force);
    }

    public void TentarPular(bool _jumpInput, float _forcaPulo)
    {
        // pulo 
        if( _jumpInput && castManager.CheckCast("Ground") )
        {
            meuRb.AddForce(Vector3.up * _forcaPulo, ForceMode.Impulse);
        }
    }

}
