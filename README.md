# Simple pool with a unity like signature of methods.

### Use:

`using GameObjectPooling;`


### Examples:

`GameObjectPool.Instantiate(prefab, position, Quaternion.identity);`

`Rigidbody instance = GameObjectPool.Instantiate<Rigidbody>(prefab, parent);`

`GameObjectPool.Destroy(object);`


### Methods:

```
public static T Instantiate<T>(T original) where T : Component;

public static GameObject Instantiate(GameObject original, Vector3 position, 
    Quaternion rotation);

public static GameObject Instantiate(GameObject original, Vector3 position, 
    Quaternion rotation, Transform parent);

public static GameObject Instantiate(GameObject original);

public static GameObject Instantiate(GameObject original, Transform parent);

public static T Instantiate<T>(T original, Transform parent, 
    bool worldPositionStays) where T : Component;

public static T Instantiate<T>(T original, Transform parent) where T : Component;

public static T Instantiate<T>(T original, Vector3 position, 
    Quaternion rotation, Transform parent) where T : Component;

public static T Instantiate<T>(T original, Vector3 position, 
    Quaternion rotation) where T : Component;

public static GameObject Instantiate(GameObject original, Transform parent, 
    bool instantiateInWorldSpace);

public static void Destroy(GameObject obj);

public static void Destroy(GameObject obj, [DefaultValue("0.0F")] float t);
```
