using UnityEngine;

public class MovimentacaoBola : MonoBehaviour
{

    [SerializeField] private float velocidadeBola = 6f;

    [SerializeField] private float direcaoAleatoriaX = 0.5f;

    [SerializeField] private float direcaoAleatoriay = 0.5f;

    [SerializeField] private Rigidbody2D oRigidbody2D;

    [SerializeField] private AudioSource somBola;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoverBola();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void MoverBola()
    {
        oRigidbody2D.linearVelocity = new Vector2(velocidadeBola, velocidadeBola);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        somBola.Play();

        oRigidbody2D.linearVelocity += new Vector2(direcaoAleatoriaX, direcaoAleatoriay);
    }
}
