using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
// Liste des éléments HUD.
[SerializeField]
private GameObject ecranAccueil;
[SerializeField]
private GameObject menuSelection;
[SerializeField]
private GameObject menuStages;
[SerializeField]
private GameObject pageOptions;
[SerializeField]
private GameObject pageGuide;
[SerializeField]
// Tableau contenant tous les menus pour faciliter leur gestion.
private GameObject[] menus;

    // Au démarrage du script.
    void Start()
    {
        // Désactiver tous les menus au démarrage.
        foreach (GameObject menu in menus)
        {
            menu.SetActive(false);
        }
        // Activer l'écran d'accueil par défaut.
        AfficherMenu(ecranAccueil);
    }

    // A chaque frame.
    void Update()
    {
        
    }

    // Méthode pour afficher un menu spécifique en masquant les autres.
    public void AfficherMenu(GameObject menuAAfficher)
    {
        // Masquer tous les menus.
        foreach (GameObject menu in menus)
        {
            menu.SetActive(false);
        }

        // Afficher le menu demandé.
        menuAAfficher.SetActive(true);
    }

    // Liste des méthodes pour  les boutons dans l'inspecteur Unity.
    public void AfficherMenuSelection()
    {
        AfficherMenu(menuSelection);
    }

    public void AfficherMenuStages()
    {
        AfficherMenu(menuStages);
    }

    public void AfficherPageOptions()
    {
        AfficherMenu(pageOptions);
    }

    public void AfficherPageGuide()
    {
        AfficherMenu(pageGuide);
    }
    public void TestButton()
    {
        Debug.Log("Test button pressed");
    }
}