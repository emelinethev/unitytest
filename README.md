# unitytest

## Vie et Mort
Pour détruire un composant OU un game object :


```csharp
Destroy(gameObject);
// avec un délai :
Destroy(gameObject, 3f);
```

Pour créer un gameObject à partir d'une source :
- existant dans la scène :
```csharp
Instantiate(gameObject);

- en récupérant l'instance crée pour la détruire ensuite :
```csharp
GameObject clone = Instantiate (gameObject);
Destroy (clone,5f);
```

[voir usage dans CloneOnCLick.cs](./Assets/CloneOnCLick.cs)

