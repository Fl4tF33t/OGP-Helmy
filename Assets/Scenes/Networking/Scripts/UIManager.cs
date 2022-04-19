using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.Netcode;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    Button startServerButton;

    [SerializeField]
    Button startHostButton;

    [SerializeField]
    Button startClientButton;

    [SerializeField]
    TextMeshProUGUI playersInGameText;

    private void Awake()
    {
        Cursor.visible = true;
    }

    private void Start()
    {
        startHostButton.onClick.AddListener(() =>
        {
            if (NetworkManager.Singleton.StartHost())
            {
                Debug.Log("Host Started");
            }
            else
            {
                Debug.Log("Could not Start Host");
            }
        });

        startServerButton.onClick.AddListener(() =>
        {
            if (NetworkManager.Singleton.StartServer())
            {
                Debug.Log("Server Started");
            }
            else
            {
                Debug.Log("Could not Start Server");
            }
        });

        startClientButton.onClick.AddListener(() =>
        {
            if (NetworkManager.Singleton.StartClient())
            {
                Debug.Log("Client Started");
            }
            else
            {
                Debug.Log("Could not Start Client");
            }
        });
    }

    private void Update()
    {
        //playersInGameText.text = "Player numbers: " + PlayersManager.Instance.playersInGame;
    }
}
