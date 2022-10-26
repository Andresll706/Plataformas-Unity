using UnityEngine;
using System.Collections;

public class StickyFloor : MonoBehaviour {

    private Transform m_originalParent = null;
    public Transform m_transformToAttach;

    void Start()
    {
        if (m_transformToAttach == null)
            m_transformToAttach = transform;
    }

    void OnTriggerEnter(Collider other)
    {
        //TODO 1: Cuando el objeto que caiga sea attachable, atachamos el objeto.
        if (other.CompareTag("Player")) {
            Attachable attachable = other.GetComponent<Attachable>();
            if (attachable.IsAttachable && !attachable.IsAttached) {
                m_originalParent = other.transform.parent;
                other.transform.parent = m_transformToAttach;
                attachable.IsAttached = true;
            }
        }

    }

    void OnTriggerExit(Collider other)
    {
        //TODO 2: Cuando el objeto que caiga sea attachable, como estamos saliendo, desatachamos el objeto. Ojo, la scala puede cambiar!!!
        Attachable attachable = other.gameObject.GetComponent<Attachable>();
        if (attachable.IsAttachable && attachable.IsAttached)
        {
            other.transform.parent = m_originalParent;
            attachable.IsAttached = false;
        }
    }
}
