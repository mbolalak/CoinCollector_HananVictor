using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryManager : MonoBehaviour
{
    InputAction inventoryAction;
    [SerializeField] private GameObject InventoryCanvas;
    private bool InventoryActive;

    void Start()
    {
        inventoryAction = InputSystem.actions.FindAction("Inventory");
        InventoryCanvas.SetActive(false);
        InventoryActive = false;
    }

    void Update()
    {
        // Cek dulu canvas-nya ada apa nggak, terus cek tombolnya ditekan atau nggak
        if (InventoryCanvas != null && inventoryAction.WasPressedThisFrame())
        {
            // Kalau lagi ketutup, kita buka
            if (InventoryActive == false) 
            {
                InventoryActive = true;
                InventoryCanvas.SetActive(true);
                Time.timeScale = 0f; // Pause game

                Debug.Log("E di pencet, inventory buka");
            }
            // Kalau lagi kebuka, kita tutup
            else 
            {
                InventoryActive = false;
                InventoryCanvas.SetActive(false);
                Time.timeScale = 1f; // Resume game

                Debug.Log("Inventory tutup");
            }
        }
    }
}