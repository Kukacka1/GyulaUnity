using UnityEngine;

class Damager : MonoBehaviour
{
    [SerializeField] int damage = 10;


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Én:  " + name + "  Ütköztem : " + other.name);

        Damageable damageable = other.GetComponent<Damageable>();
        if (damageable != null)
        {
            damageable.Damage(damage);
      
        }

       
        
        
    }







}
