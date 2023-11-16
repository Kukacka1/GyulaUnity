using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] int startHP = 100;
    public void Damage(int damage)
    {


        Debug.Log("Áucs!!!!!");

     
        startHP -= damage;

        if (startHP <= 0)
        {

            Debug.Log("GameOver");

        }
    }
}
