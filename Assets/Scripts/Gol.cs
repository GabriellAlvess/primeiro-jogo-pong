using UnityEngine;


public class Gol : MonoBehaviour
{
    [SerializeField] private bool golDoJogador1;
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (golDoJogador1 == true)
        {
            FindAnyObjectByType<GameManager>().AumentarPontosJogador2();
            other.gameObject.transform.position = new Vector2(0, 0);

        }
        else
        {
            FindAnyObjectByType<GameManager>().AumentarPontosJogador1();
            other.gameObject.transform.position = new Vector2(0, 0);
        }
    }
}
