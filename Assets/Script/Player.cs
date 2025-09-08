using System.Drawing;
using TMPro;
using Unity.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    TextMeshProUGUI texto;
    //TextMeshProUGUI texto2;
    //Animator anime;
    //Transform ferro;
    Transform player;
    Transform parede;
    public float velocidade = 7;
    public float y;
    public float x;
    public int minerio = 0;
    int vida;
    public bool estaDireita = true;
    Vector3 vect;
    bool chao = true;

    void Start()
    {
        texto = GameObject.Find("Mineriodeferro").transform.GetComponent<TextMeshProUGUI>();
        ////texto2 = GameObject.Find("Vida").transform.GetComponent<TextMeshProUGUI>();
        //ferro = GameObject.Find("Minério de Ferro").transform;
        player = GameObject.Find("Player").transform;
        //anime = transform.GetComponent<Animator>();

        parede = GameObject.Find("Parede lateral").transform;
        vect = transform.position;


        vect = transform.position;
        //vida = 4;
        //texto2.text = "Vida: <color=green> " + vida + " </color> ";
    }

    // Update is called once per frame
    void Update()
    {


        float movimente = Input.GetAxisRaw("Horizontal");
        if (movimente == 1)
        {
            transform.eulerAngles = new Vector2(0, 0);
            estaDireita = true;
            //Instanciado.GetComponent<Projetil>().direcao = new Vector2(1, 0);
        }

        if (movimente == -1)
        {
            transform.eulerAngles = new Vector2(0, 180);
            estaDireita = false;
        }
        if (Input.GetKeyDown(KeyCode.T) == true)
        {
            //Transform Instanciado = Instantiate(projetil);
            //Instanciado.position = transform.position;
            //Instanciado.GetComponent<Projetil>().enabled = true;


            //if (estaDireita == true)
            //{
            //    Instanciado.GetComponent<Projetil>().direcao = new Vector2(1, 0);
            //}

            //else
            //{
            //    Instanciado.GetComponent<Projetil>().direcao = new Vector2(-1, 0);
            //}
        }
        movimente = movimente * velocidade;


        float pulo = Input.GetAxis("Vertical");


        transform.position += new Vector3(movimente * Time.deltaTime, pulo * velocidade * Time.deltaTime);

        //if (movimente < 0.1f && movimente > -0.1f)
        //{
        //    anime.SetBool("estaAndando", false);


        //}

        //else
        //{

        //    anime.SetBool("estaAndando", true);


        //}
        //texto2.text = "Vida: <color=green> " + vida + " </color> ";

        //if (vida == 1)
        //{

        //    texto2.text = "Vida: <color=red> " + vida + " </color> ";


        //}
        //if (pulo > 0.1f)
        //{

        //    anime.SetBool("estaPulando", true);

        //}

        //else
        //{
        //    anime.SetBool("estaPulando", false);

        //} 




    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //
        //{
        //    transform.position = vect;
        //    n = 0;


        //    Debug.Log("Parabéns !! Você pegou:"); 

        //    vida--;



        //}
        if (collision.gameObject.name.Contains("Comum") == true)
        {

            Destroy(collision.gameObject);

            //Debug.Log("Parabéns !! Você pegou:" + n++);


        }

        if (collision.gameObject.name.Contains("Minério de Ferro") == true)
        {

            Destroy(collision.gameObject);
            minerio++;
            texto.text = "Minério de ferro:" + minerio;
        }

        if (minerio >= 5)
        {
            if (collision.gameObject.name.Contains("Rara") == true)
            {
                Destroy(collision.gameObject);
            }

        }

        if(collision.gameObject.name.Contains("Costela") == true)
        {
            Destroy(collision.gameObject);
            texto.text = "Minério de ferro:" + (2 - minerio--);
        }


        if (collision.gameObject.name.Contains("Cranio1") == true)
        {
            Destroy(collision.gameObject);
            texto.text = "Minério de ferro:" + (2 - minerio--);
        }


        if (collision.gameObject.name.Contains("OssoAleatório1") == true)
        {
            Destroy(collision.gameObject);
            texto.text = "Minério de ferro:" + (2 - minerio--);
        }

        if (collision.gameObject.name.Contains("OssoAleatório2") == true)
        {
            Destroy(collision.gameObject);
            texto.text = "Minério de ferro:" + (2 - minerio--);
        }

        if (collision.gameObject.name.Contains("Mandibula") == true)
        {
            Destroy(collision.gameObject);
            texto.text = "Minério de ferro:" + (2 - minerio--);
        }

        if (collision.gameObject.name.Contains("Mao") == true)
        {
            Destroy(collision.gameObject);
            texto.text = "Minério de ferro:" + (2 - minerio--);
        }

        if (collision.gameObject.name.Contains("OssoQuebrado") == true)
        {
            Destroy(collision.gameObject);
            texto.text = "Minério de ferro:" + (2 - minerio--);
        }

        if (collision.gameObject.name.Contains("CranioQuebrado") == true)
        {
            Destroy(collision.gameObject);
            texto.text = "Minério de ferro:" + (2 - minerio--);
        }

    }
}
