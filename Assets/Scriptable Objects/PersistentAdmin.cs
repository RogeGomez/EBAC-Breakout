using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentAdmin : MonoBehaviour
{
    public List<PersistentScore> ObjectsToSave;

    private void OnEnable()
    {
        for (int i = 0; i < ObjectsToSave.Count; i++)
        {
            var so = ObjectsToSave[i];
            so.Load();
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < ObjectsToSave.Count; i++)
        {
            var so = ObjectsToSave[i];
            so.Save();
        }
    }
}
