using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public static Movimiento instance;
    [SerializeField]
    public float velocidad;
    public bool isAlive;
    private Transform myTransform;




    // Start is called before the first frame update
    void Start()
    {
        velocidad = 6;

    }

    private void FixedUpdate()
    {
        myTransform = GetComponent<Transform>();
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        isAlive = true;
        SetCamerasX();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myTransform.Translate(new Vector3(0, 10, 0) * Time.deltaTime);
        }
    }
    void SetCamerasX()
    {
        camaraScript.offsetX = (Camera.main.transform.position.x - transform.position.x) - 1f;
    }
    public float GetPositionX ()
    {
        return transform.position.x;
    }
    
}