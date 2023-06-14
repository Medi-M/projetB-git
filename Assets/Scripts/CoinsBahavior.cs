using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsBahavior : MonoBehaviour
{
    public int value = 1;
    private GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("CoinAmount");
    }

    // Update is called once per frame
    void Update()
    {

    }
    protected virtual void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            int coinUI = int.Parse(UI.GetComponent<UnityEngine.UI.Text>().text) + value;
            UI.GetComponent<UnityEngine.UI.Text>().text = coinUI + "";
            Destroy(gameObject);
        }

    }
}


/*void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))  // Quand le perso entre col avec piece
        {
                int coinUI = int.Parse(UI.GetComponent<Text>().text) + value;
                UI.GetComponent<Text>().text = coinUI + "";
                Destroy(gameObject);
            
        }
    }*/