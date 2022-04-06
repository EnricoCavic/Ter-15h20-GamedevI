using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// atributo que permite criar novas instâncias deste objeto pelo editor
[CreateAssetMenu(fileName = "Nova GeeksCard", menuName = "ScriptableObj/GeeksCard")]
public class GeeksCard : ScriptableObject
{
    public string nome;

    // variável do mesmo tipo desssa carta
    public GeeksCard evolution;

    // text area aumente o espaço para escrever
    [TextArea] public string efeito;

    // declarando várias vars do mesmo tipo em uma linha
    public int vida, ataque, defesa, velocidade;

    // colocando valor min e max para a var
    [Range(0, 20)] public int custo;

    public Sprite imagem;

    public bool rebaixado;
}
