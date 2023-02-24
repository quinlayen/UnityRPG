using System.Collections;
using System.Collections.Generic;
using Unity.Services.Lobbies;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Lobbies;
using Unity.Services.Lobbies.Models;

public class LobbyManager : MonoBehaviour
{
   public async void CreateLobby()
   {
      string lobbyName = "TestLobby";
      int maxPlayers = 4;
      Lobby lobby = await LobbyService.Instance.CreateLobbyAsync(lobbyName, maxPlayers);
   }
}
