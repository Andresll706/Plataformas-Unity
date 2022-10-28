using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneTravel : MonoBehaviour
{
    public Camera m_Camera;
    public Transform m_Target;
    public float m_TravelTime;
    public float m_TimeCameraStop;

    private Camera m_MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        m_Camera.gameObject.SetActive(false);
        GameObject cameraGo = GameObject.FindGameObjectWithTag("MainCamera");
        m_MainCamera = cameraGo.GetComponent<Camera>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Travel());
        }
    }

    IEnumerator Travel()
    {
        Vector3 direction = Vector3.zero;
        Vector3 initialPosition = m_Camera.transform.position;
        //## TODO 1 Desactivamos la cámara principal y activamos la camara del travel.

        float time = 0;
        do
        {
            //## TODO 2 Hasta que no lleguemos a la distancia mínima, movemos la cámara a la velocidad necesaria para que la transición tarde m_TravelTime segundos.

            yield return new WaitForEndOfFrame();
        }
        while (time < m_TravelTime);
        //TODO 3 esperamos un tiempo para volver a la normalidad.

        //TODO 4 reseteamos las cámaras para dejarlo todo como estaba.

    }

}
