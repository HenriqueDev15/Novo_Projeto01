using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    // Start is called before the first frame update

    public int numero = 10;

    private Rigidbody2D _rigidbody2D;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
            
            
        Debug.Log("Teste..."+ numero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
