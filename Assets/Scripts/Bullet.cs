
using UnityEngine;

 class Bullet : MonoBehaviour
{



    [SerializeField] float speed = 10;
   
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
