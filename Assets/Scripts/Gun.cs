using UnityEngine;


class Gun : MonoBehaviour
{
    [SerializeField] int ammo = 5;
    [SerializeField] int magazineSize = 10;
    [SerializeField] int magazineCount = 5;
    [SerializeField] bool isMachineGun = false;
    [SerializeField] string fireText = "Bang";
    [SerializeField] string realoadText = "Click";
    [SerializeField] float coolDown = 0.1f;
    [SerializeField] GameObject bullet;
    [SerializeField] KeyCode reloadKey = KeyCode.X;
    [SerializeField] KeyCode shootKey = KeyCode.Space;
    float lastShootTime;

    void Update()
    {
        bool shoot;
        float currentTime = Time.time;
        float duration = currentTime - lastShootTime;

        if (duration >= coolDown)
        {
            if (isMachineGun)
            {
                shoot = Input.GetKey(shootKey);
            }
            else
            {
                shoot = Input.GetKeyDown(shootKey);
            }
        }
        else
        {
            shoot = false;
        }
        if (shoot)
        {
            if (ammo > 0)
            {
                Debug.Log(fireText);
                ammo--;
                lastShootTime = Time.time;

                Instantiate(bullet);
            }


        }


        if (Input.GetKeyDown(reloadKey))
        {

            if (magazineCount > 0)
            {
                Debug.Log(realoadText);
                magazineCount--;
                ammo = magazineSize;

            }
        }
    }
}
