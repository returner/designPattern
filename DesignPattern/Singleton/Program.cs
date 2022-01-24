using DesignPattern.Singleton;

var singletonNotThreadSafe = SingletonNotThreadSafe.Instance;
await singletonNotThreadSafe.GetMethodAsync();

var lockSingleton = LockSingleton.Instance;
await lockSingleton.GetMethodAsync();

var staticSingleton = StaticSingleton.Instance;
await staticSingleton.GetMethodAsync();

var lazySingleton = LazySingleton.Instance;
await lazySingleton.GetMethodAsync();
