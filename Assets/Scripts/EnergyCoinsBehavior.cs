using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnergyCoinsBehavior : MonoBehaviour
{
    public int value = 50;
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
    /*protected override void OnTriggerEnter2D(Collider2D col)
    {
        base.OnTriggerEnter2D(col);
    }*/



}

        /*if (col.gameObject.CompareTag("Player"))
        {
            int coinUI = int.Parse(UI.GetComponent<Text>().text) + value;
            UI.GetComponent<Text>().text = coinUI.ToString();
            Destroy(gameObject);
        }*/