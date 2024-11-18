using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    public PlayerHealth1 playerhealth1; // Refer�ncia ao script com a vari�vel

    void OnGUI()
    {
        if (playerhealth1 != null)
        {
            // Exibe a vari�vel score na tela
            GUI.Label(new Rect(10, 10, 200, 20), "Health: " + playerhealth1.health);
        }
        else
        {
            GUI.Label(new Rect(10, 10, 200, 20), "PlayerStats n�o atribu�do!");
        }
    }
}
