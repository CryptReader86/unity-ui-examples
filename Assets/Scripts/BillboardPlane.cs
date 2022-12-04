using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardPlane : MonoBehaviour
{
    [SerializeField]
    private Camera _mainCamera;

    private void Update()
    {
        transform.LookAt(2 * transform.position - _mainCamera.transform.position);
    }
}
