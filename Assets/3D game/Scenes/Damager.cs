using UnityEngine;

class Damager : MonoBehaviour
{
    [SerializeField] int damage = 10;


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("�n:  " + name + "  �tk�ztem : " + other.name);

        Damageable damageable = other.GetComponent<Damageable>();
        if (damageable != null)
        {
            damageable.Damage(damage);
      
        }

       
        
        
    }







}
