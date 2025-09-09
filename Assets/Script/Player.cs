using System.Drawing;
using TMPro;
using Unity.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    TextMeshProUGUI texto;
    TextMeshProUGUI texto2;
    Animator anime;
    //Transform ferro;
    Transform player;
    Transform parede;
    public float velocidade = 7;
    public float y;
    public float x;
    public int minerio = 0;
    public int ossos = 0;
    int vida;
    public bool estaDireita = true;
    bool masmorra = true;
    public int pedra = 0;
    Vector3 vect;
    bool chao = true;
    float movimente;

    void Start()
    {
        texto = GameObject.Find("Mineriodeferro").transform.GetComponent<TextMeshProUGUI>();
       texto2 = GameObject.Find("ReduzSkill").transform.GetComponent<TextMeshProUGUI>();
        //ferro = GameObject.Find("Minério de Ferro").transform;
        player = GameObject.Find("Player").transform;

           anime = transform.GetComponent<Animator>();

        parede = GameObject.Find("Parede lateral").transform;
        vect = transform.position;


        vect = transform.position;
        //vida = 4;
        //texto2.text = "Vida: <color=green> " + vida + " </color> ";
    }

    // Update is called once per frame
    void Update()
    {


        movimente = Input.GetAxisRaw("Horizontal");

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
   
        movimente = movimente * velocidade;


        float pulo = Input.GetAxis("Vertical");


        transform.position += new Vector3(movimente * Time.deltaTime, pulo * velocidade * Time.deltaTime);

        if (movimente < 0.1f && movimente > -0.1f)
        {
            anime.SetBool("EstaAndando", false);


        }
        else {

            anime.SetBool("EstaAndando", true);
        }

        //if (vida == 1)
        //{

        //    texto2.text = "Vida: <color=red> " + vida + " </color> ";


        //}


        if (Input.GetKey(KeyCode.T) == true)
        {

            anime.SetBool("EstaAtacando", true);

        }

        else
        {
            anime.SetBool("EstaAtacando", false);

        }



    }

    private void OnCollisionEnter2D(Collision2D collision )
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
            pedra++;
            Destroy(collision.gameObject);
            Debug.Log(pedra);

            //Debug.Log("Parabéns !! Você pegou:" + n++);


        }

        if (collision.gameObject.name.Contains("Minério de Ferro") == true)
        {

            Debug.Log(pedra);
            Destroy(collision.gameObject);
            minerio++;
            pedra++;
          

            texto.text = "Minério de ferro:" + minerio;
            
        }

        if (minerio >= 5)
        {
            if (collision.gameObject.name.Contains("Rara") == true)
            {
                Destroy(collision.gameObject);
                pedra++;
                Debug.Log(pedra);


            }

        }

        if (pedra == 2194)
        {
            SceneManager.LoadScene("Menu");

        }

        if (collision.gameObject.name.Contains("Costela") == true)
        {
            Destroy(collision.gameObject);
            minerio--;
            minerio--;
            ossos++;
            texto2.text = "Caveira:" + ossos;
            texto.text = "Minério de ferro:" + minerio;
        }


        if (collision.gameObject.name.Contains("Cranio1") == true)
        {
            Destroy(collision.gameObject);
            minerio--;
            minerio--;
            minerio--;
            minerio--;
            ossos++;
            texto2.text = "Caveira:" + ossos;
            texto.text = "Minério de ferro:" + minerio;
        }


        if (collision.gameObject.name.Contains("OssoAleatório1") == true)
        {
            Destroy(collision.gameObject);
            minerio--;
            minerio--;
            ossos++;
            texto2.text = "Caveira:" + ossos;
            texto.text = "Minério de ferro:" + minerio;
        }

        if (collision.gameObject.name.Contains("OssoAleatório2") == true)
        {
            Destroy(collision.gameObject);
            minerio--;
            minerio--;
            ossos++;
            texto2.text = "Caveira:" + ossos;
            texto.text = "Minério de ferro:" + minerio;
        }

        if (collision.gameObject.name.Contains("Mandibula") == true)
        {
            Destroy(collision.gameObject);
            minerio--;
            minerio--;
            ossos++;
            texto2.text = "Caveira:" + ossos;
            texto.text = "Minério de ferro:" + minerio;
        }

        if (collision.gameObject.name.Contains("Mao") == true)
        {
            Destroy(collision.gameObject);
            minerio--;
            minerio--;
            minerio--;
            minerio--;
            ossos++;
            texto2.text = "Caveira:" + ossos;
            texto.text = "Minério de ferro:" + minerio;
        }

        if (collision.gameObject.name.Contains("OssoQuebrado") == true)
        {
            Destroy(collision.gameObject);
            minerio--;
            minerio--;
            ossos++;
            texto2.text = "Caveira:" + ossos;
            texto.text = "Minério de ferro:" + minerio;
        }

        if (collision.gameObject.name.Contains("CranioQuebrado") == true)
        {
            Destroy(collision.gameObject);
            minerio = 0;
            ossos++;
            texto2.text = "Caveira:" + ossos;
            texto.text = "Minério de ferro:" + minerio;
            
            SceneManager.LoadScene("Fim2");
        }


    }
}
