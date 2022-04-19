using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using DilmersGames.Core.Singletons;

public class PlayersManager : Singleton<PlayersManager>
{
    public NetworkVariable<int> playersInGame = new NetworkVariable<int>();

    public int PlayersInGame
    {
        get
        {
            return playersInGame.Value;
        }
    }

    private void Start()
    {
        NetworkManager.Singleton.OnClientConnectedCallback += (id) =>
        {
            if (IsServer)
            {
                Debug.Log($"{id} Connected");
                playersInGame.Value++;
            }
        };

        NetworkManager.Singleton.OnClientDisconnectCallback += (id) =>
        {
            if (IsServer)
            {
                Debug.Log($"{id} Disconnected");
                playersInGame.Value--;
            }
        };

    }
}
