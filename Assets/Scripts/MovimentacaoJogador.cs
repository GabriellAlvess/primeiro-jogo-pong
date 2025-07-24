using UnityEngine;

public class MovimentacaoJogador : MonoBehaviour
{
    [SerializeField] private float velocidadeDoJogador = 7f;

    [SerializeField] private bool jogador1;

    [SerializeField] private float yMinimo = -4.0f;
    [SerializeField] private float yMaximo = 4.0f;

    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (jogador1 == true)
        {
            MoverJogador1();
        }
        else
        {
            MoverJogador2();
        }
    }

    private void MoverJogador1()
    {
        // Limitar o movimento do jogador dentro dos limites especificados
        transform.position = new Vector2(transform.position.x,
            Mathf.Clamp(transform.position.y, yMinimo, yMaximo));

        // Movimentação do jogador 1 com as teclas W e S
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }
    
    private void MoverJogador2()
    {
        // Limitar o movimento do jogador dentro dos limites especificados
        transform.position = new Vector2(transform.position.x,
            Mathf.Clamp(transform.position.y, yMinimo, yMaximo));

        // Movimentação do jogador 2 com as teclas de seta up e down
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }
}
