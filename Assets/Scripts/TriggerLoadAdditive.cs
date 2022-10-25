using UnityEngine;
using UnityEngine.SceneManagement; 

public class TriggerLoadAdditive : MonoBehaviour
{
    // TODO 1 - Añadir variable pública con el color de la puerta (tipo GameManager.DoorColor)
    public GameManager.DoorColor doorColor;
    /// <summary>
    /// La comprobación del tipo de gameobject que entra en el trigger se hace por tag
    /// El valor del tag que nos interesa se guarda en esta variable
    /// </summary>
    private string m_PlayerTag = "Player";


    /// <summary>
    /// Detecta cuándo un GameObject entra en el trigger al cual está asignado este componente.
    /// En nuestro caso, realizamos la carga aditiva del nivel indicado en el atributo
    /// público "LevelToLoadName"
    /// </summary>
    void OnTriggerEnter(Collider other)
	{
        if (other.CompareTag(m_PlayerTag))
        {
            string sceneName = null;
            switch (doorColor) {
                case GameManager.DoorColor.GREEN: 
                    sceneName = "GreenWorld"; 
                    break;
                case GameManager.DoorColor.RED:
                    sceneName = "RedWorld";
                    break;
                case GameManager.DoorColor.BLUE:
                    sceneName = "BlueWorld";
                    break;
                case GameManager.DoorColor.YELLOW:
                    sceneName = "YellowWorld";
                    break;
            }

            if (sceneName != null)
            {
                SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
                this.enabled = false;
            }
        }
		//LoadLevelAdditive(other.gameObject);
	}


    // TODO 2 - Hacer función que cargue un nivel de forma aditiva.
    // Será necesario pasarle el gameObject que ha colisionado con el trigger
    // Tras cargar el nivel, desactivamos el trigger
    
}