using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject inputGOTarget;
    public Text inputScoreText;
    public GameObject inputWin;

    private int score = 0;
    private bool win = false;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAparecer", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (win == true) {
            CancelInvoke("SpawnAparecer");    
        }

        /*if (Input.GetMouseButtonDown(0)) {
             GetComponent<AudioSource>().Play();
        }*/
    }

    void SpawnAparecer(){
        float randomX = Random.Range(-8.4f,8.4f);
        float randomY = Random.Range(-4.6f,4.6f);

        Vector3 position = new Vector3(randomX,randomY,0);

        Instantiate(inputGOTarget,position, Quaternion.identity);
    }

    public void IncrementScore(){
        score ++;
        inputScoreText.text = score.ToString();

        if(score >= 10){
            win = true;
            inputWin.SetActive(true);
        }
    }
}
