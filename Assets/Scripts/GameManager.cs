using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] private int pontosJogador1;
    [SerializeField] private int pontosJogador2;
    [SerializeField] private Text textoDePontuacao;
    [SerializeField] private AudioSource somGol;
    void Start()
    {
        pontosJogador1 = 0;
        pontosJogador2 = 0;

        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) || pontosJogador1 >= 5 || pontosJogador2 >= 5)
        {
            ReiniciarPartida();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SairDoJogo();
        }
    }

    public void AumentarPontosJogador1()
    {
        pontosJogador1 += 1;
        AtualizarTextoPontuacao();
    }

    public void AumentarPontosJogador2()
    {
        pontosJogador2 += 1;
        AtualizarTextoPontuacao();
    }

    public void AtualizarTextoPontuacao()
    {
        textoDePontuacao.text = $"{pontosJogador1} x {pontosJogador2}";
        somGol.Play();
    }

    private void ReiniciarPartida()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SairDoJogo()
    {
        Application.Quit();
        Debug.Log("Saindo do jogo...");
    }
    

}
