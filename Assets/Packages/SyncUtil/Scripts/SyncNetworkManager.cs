﻿using UnityEngine.Networking;

namespace SyncUtil
{
    [System.Serializable]
    public class SyncNetworkManager : NetworkManager
    {
        public static new SyncNetworkManager singleton { get { return NetworkManager.singleton as SyncNetworkManager; } }


        #region Server side

        public event System.Action _OnStartServer = delegate { };
        public override void OnStartServer()
        {
            base.OnStartServer();
            _OnStartServer();
        }

        public event System.Action<NetworkConnection> _OnServerConnect = delegate { };
        public override void OnServerConnect(NetworkConnection conn)
        {
            base.OnServerConnect(conn);
            _OnServerConnect(conn);
        }

        public event System.Action<NetworkConnection> _OnServerDisconnect = delegate { };
        public override void OnServerDisconnect(NetworkConnection conn)
        {
            base.OnServerDisconnect(conn);
            _OnServerDisconnect(conn);
        }

        #endregion


        #region Client side

        public event System.Action _OnStartClient = delegate { };
        public override void OnStartClient(NetworkClient client)
        {
            base.OnStartClient(client);
            _OnStartClient();
        }

        public event System.Action<NetworkConnection> _OnClientConnect = delegate { };
        public override void OnClientConnect(NetworkConnection conn)
        {
            base.OnClientConnect(conn);
            _OnClientConnect(conn);
        }
        #endregion
    }
}