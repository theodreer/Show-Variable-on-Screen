using UnityEngine;

public class NameOfFile : MonoBehaviour
{
    public ScritptWithVariable scriptwithvariable; // Referência ao script com a variável // TROQUE ESTA MERDA PELO NOME CERTO

    void OnGUI()
    {
        if (scriptofvariable != null)
        {
            // Exibe a variável desejada na tela
            GUI.Label(new Rect(10, 10, 200, 20), "Variable: " + ScritptWithVariable.Variable);
                                                        // Script Com o que você quer "." O que você quer.
        }
        else
        {
            GUI.Label(new Rect(10, 10, 200, 20), "No Variable!");
        }
    }
}
