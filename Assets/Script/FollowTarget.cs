using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform target;
    public Vector3 offset = new Vector3 (0, 0, 0);
    void Start()
    {
       if(target == null)
        {
            Debug.Log("Você errou, não Colocou Target neste script");
            Destroy(this);
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
