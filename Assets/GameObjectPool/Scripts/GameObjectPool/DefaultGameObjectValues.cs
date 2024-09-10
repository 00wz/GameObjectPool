using UnityEngine;

namespace GameObjectPooling
{
    public struct DefaultGameObjectValues
    {
        public Vector3 Position { get; }
        public Quaternion Rotation { get; }
        public Vector3 Scale { get; }
        public bool IsEnable { get; }

        public DefaultGameObjectValues(GameObject prefab)
        {
            Position = prefab.transform.position;
            Rotation = prefab.transform.rotation;
            Scale = prefab.transform.localScale;
            IsEnable = prefab.activeSelf;
        }

    }
}
