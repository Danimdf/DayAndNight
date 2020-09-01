﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoltarMenu : MonoBehaviour
{
    public int tempoParaEsperar;
    void Start() {
        Invoke("SairDosCreditos",tempoParaEsperar);
    }

    void SairDosCreditos() {
        Debug.Log (LoadLevel1.instance);
        LoadLevel1.instance.FadeToLevel();
    }
}