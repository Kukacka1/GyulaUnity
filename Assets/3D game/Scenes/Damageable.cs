using TMPro;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] int startHP = 100;
    [SerializeField] TMP_Text uiText;

    void Start()
    {
        UpdateUI();

    }
    public void Damage(int damage)
    {

        startHP -= damage;
        startHP = Mathf.Max(startHP, 0);


        Debug.Log("Áucs!!!!!");
        UpdateUI();

        if (startHP <= 0)
        {

            Debug.Log("Game Over");

            PlayerMoveing pm = GetComponent<PlayerMoveing>();
            pm.enabled = false;

        }
    }

    void UpdateUI()
    {
        if (uiText != null)
        {

            uiText.text = startHP.ToString();

        }
    }
}
