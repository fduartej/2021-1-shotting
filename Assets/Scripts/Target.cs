using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager= 
            GameObject.Find("EventSystem").GetComponent<GameManager>();
        Destroy(gameObject, 2f);
    }

    void OnMouseDown()
    {
        gameManager.IncrementScore();
        Destroy(gameObject);
    }

}
