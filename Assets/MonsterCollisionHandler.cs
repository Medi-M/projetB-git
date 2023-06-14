using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterCollisionHandler : MonoBehaviour
{
    public GameObject goPan;
    private void OnCollisionEnter2D(Collision2D col)
    {
        /*if (collision.gameObject.CompareTag("Monstre"))
        {
            // Détruire le personnage ou déclencher une animation de mort du personnage
            Destroy(col.gameObject);

            // Afficher le panneau "GameOverPanel"
            goPan.SetActive(true);
            // Vous pouvez utiliser une référence ou une méthode de recherche pour activer le panneau
        }*/
    }
}
