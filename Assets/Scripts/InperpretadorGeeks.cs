using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InperpretadorGeeks : MonoBehaviour
{

    public GeeksCard cartaAMostrar;

    public Text nome, custo, efeito, ataque, defesa, rebaixado;

    public RawImage imagem;

    // Start is called before the first frame update
    void Start()
    {
        MostrarCarta();
    }

    // Update is called once per frame
    void Update()
    {
        MostrarCarta();
    }

    void MostrarCarta()
    {
        nome.text = cartaAMostrar.nome;
        custo.text = "Custo: " + cartaAMostrar.custo.ToString();
        efeito.text = "Efeito: " + cartaAMostrar.efeito;
        ataque.text = cartaAMostrar.ataque.ToString();
        defesa.text = cartaAMostrar.defesa.ToString();

        imagem.texture = cartaAMostrar.imagem.texture;

    }
}
