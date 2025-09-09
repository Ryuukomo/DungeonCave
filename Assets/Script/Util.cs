using UnityEngine;

public class Util : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    /// <summary>
    /// O transform de origem passado aqui irá olhar/rotacionar para objeto alvo
    /// </summary>
    /// <param name="ori"></param>
    /// <param name="objeto"></param>
public static void OlharObj(Transform ori, Vector3 objeto)
    {
        Vector3 direcao = (objeto - ori.position).normalized;

        float angulo = Mathf.Atan2(direcao.y, direcao.x) * Mathf.Rad2Deg;
        
        if(ori.GetComponent<Rigidbody2D>())
        {
           ori.GetComponent<Rigidbody2D>().rotation = angulo;
        }
        else
        {
            ori.eulerAngles = new Vector3(0,0, angulo);
        }

    }


   
}
