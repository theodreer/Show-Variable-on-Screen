using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    public PlayerHealth1 playerhealth1; // Referência ao script com a variável

    void OnGUI()
    {
        if (playerhealth1 != null)
        {
            // Exibe a variável score na tela
            GUI.Label(new Rect(10, 10, 200, 20), "Health: " + playerhealth1.health);
        }
        else
        {
            GUI.Label(new Rect(10, 10, 200, 20), "PlayerStats não atribuído!");
        }
    }
}
