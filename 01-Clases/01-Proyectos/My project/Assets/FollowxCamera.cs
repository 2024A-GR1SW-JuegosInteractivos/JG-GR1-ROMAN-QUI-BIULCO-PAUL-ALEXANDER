using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject cosaQueQuieroSeguir;
    // Start is called before the first frame update

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = cosaQueQuieroSeguir.transform.position + new Vector3(0, 0, -10);
    }
}
