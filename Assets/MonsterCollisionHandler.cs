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
            // D�truire le personnage ou d�clencher une animation de mort du personnage
            Destroy(col.gameObject);

            // Afficher le panneau "GameOverPanel"
            goPan.SetActive(true);
            // Vous pouvez utiliser une r�f�rence ou une m�thode de recherche pour activer le panneau
        }*/
    }
}
