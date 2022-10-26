using UnityEngine;
using System.Collections;

public class SuperJumpPowerUp : MonoBehaviour
{
	/// <summary>
	/// Atributo que indica el tiempo que durará el powerUp
	/// </summary>
	public float m_duration;
	/// <summary>
	/// Atributo que indica la altura máxima de salto que alcanzará
	/// el jugador cuando el power up esté activo
	/// </summary>
	public float m_SuperJumpHeight = 4.0f;

    private Renderer m_renderer;
    private Collider m_collider;
    void Start()
    {
        m_renderer = GetComponent<Renderer>();
        m_collider = GetComponent<Collider>();
    }

    /// <summary>
    /// Cuando el jugador toca el ítem, este debe otorgar la habilidad de super-salto al jugador
    /// durante un tiempo determinado
    /// </summary>
    /// <param name="other">
    /// Objeto que chica contra el item <see cref="Collider"/>
    /// </param>
    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TrailRenderer trailRenderer = other.GetComponent<TrailRenderer>();
            // TODO 1 - Le envío un mensaje "SetJumpHeight" con la altura que tengo configurada para el super-salto
            other.SendMessage("SetJumpHeight", m_SuperJumpHeight);
            // TODO 2 - Desactivo el renderer y el collider de mi gameObject
            // Pista: atributo "enabled"
            m_renderer.enabled = false;
            m_collider.enabled = false;
            // TODO Refactor 1 - Iniciar el timer del GUIManager (método StartPowerUpTimer)
            GUIManager.Instance.StartPowerUpTimer(m_duration);
            // TODO Refactor 2 - Obtener el componente TrailRenderer del jugador y activarlo
           
            trailRenderer.enabled = true;
            yield return new WaitForSeconds(m_duration);

            // TODO 3 - Envío un mensaje recuperando la altura del salto anterior
            other.SendMessage("RecoverJumpHeight");
            m_renderer.enabled = true;
            m_collider.enabled = true;
            // TODO Refactor 3 - Obtener el componente TrailRenderer del jugador y desactivarlo
            trailRenderer.enabled = false;
        }
    }
}