using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")//Condiciona para que ocurra solo con Player y no otros gameobjects.
        {
            Player player = other.GetComponent<Player>(); //Accedo a la clase Player y sus componentes

            if (player != null) //Reafirma si encontramos al componente player y evitar crashear el juego
            {
                player.TripleShootPowerOn();
            }
            Destroy(gameObject);
        }
    }
}
