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