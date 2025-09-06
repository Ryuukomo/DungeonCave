using UnityEngine;

public class Projetil : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Vector3 direcao;
    public float velocidade = 20;
  

    private void Start()
    {
        //Destroy(transform.gameObject, 5);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += direcao * velocidade * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
     
            Destroy(transform.gameObject);
        if (collision.gameObject.name.Contains("chaoDestroy") == true)
        {
            Destroy(collision.gameObject);
        }

    }
  }

