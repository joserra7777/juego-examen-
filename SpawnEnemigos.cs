using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    #region variables 
    [Header("aqui va tu enemigo")]
    public GameObject enemigo;
    [Header("aqui va tu puntp de creacion")]
    public Transform puntoDeCreacion;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0.8f, 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void spawn()
    {
        Instantiate(enemigo, puntoDeCreacion.position, puntoDeCreacion.rotation);
    }
}
