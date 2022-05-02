using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBluePrint standardTurret;
    public TurretBluePrint anotherTurret;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret Selected");
        buildManager.SelectTurretToBuild(standardTurret);

    }
    public void SelectAnotherTurret()
    {
        Debug.Log("Another Turret Selected");
        buildManager.SelectTurretToBuild(anotherTurret);
    }
}
