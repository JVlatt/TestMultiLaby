using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Pun;

    public class Test : MonoBehaviour
    {
        // Start is called before the first frame update
        public void Inst()
        {
            PhotonNetwork.Instantiate("prefab", new Vector3(0, 1, 0), Quaternion.identity, 0);
        }
    }


