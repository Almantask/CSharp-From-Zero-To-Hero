# C#: From Zero To Hero

## Chapter 6. Design Patterns. Singleton

### Intro

Singleton solves a problem of a static class. What problem that might be? 
- Static class cannot be inherited.
- Static class cannot implement an interface.
- Static class cannot use DI.

How does singleton solve this problem? Well, it's just a class.
Instead of all static memebers in a static class, we have just 1. That 1 being instance to the class itself.
Like so, we can work with a singleton just like with any other OOP class.

### Singleton is an Antipattern

Not all patterns are great. Singleton is a prime example of it. Static instance to itself is a global state.
We do not want to have a global state, we want to avoid that if possible.
Singleton is also quite prone to concurrency problems and you need extra effort to make it thread-safe.
Lastly, you create the class from within itself, which violates SRP.

There is value in every pattern and just because it has a few drawbacks, we don't want to stop using it.
Think twice before using a singleton, but if you understand the potential issues and how to tackle them- go for it!

### Singleton done right

#### Immutable

The best way to fight global state and multithreading problems is through immutability. Therefore, there is nothing wrong
with a singleton like application settings, logger (generic logger is the way though).
As long as there is 0 risk of object being changed simultaniously by multiple threads, singleton should suffice.

#### IoC container

The most common way to implement a singleton in .NET Core is through Inversion of Control container. It is not a "true" singleton,
but I strongly believe that it is the best way to provide a **single instance** of a class.
When we inject a service that has no state, but provides common logic, there is no point of making it static (because we want testability).
We can inject it in composition root as a singleton lifetme.

```
var services = new ServiceCollection();
services.AddSingleton<ICommonLogicProvider, CommonLogicProviderImplementation>();
```

#### Points of interest

`IOptions<T>` - a common interface for abstracting away, reading configuration is a singleton. If you change it, the changes will persist.

### Task

Create and three versions of a non-generic logger to a consonle: static, Singleton and injected through a container.
Create a `FooService` class that has a methods `Foo1`, `Foo2` and `Foo3` in which a logger is called.
`Foo1` calls a static logger,
`Foo2` calls non-static logger,
`Foo3` calls an injected logger.
Write tests for `FooService`.
Which method was the easiest to test?
Why?

Create a `BarService` class that has methods `Bar1`, `Bar2` and `Bar3` in which a logger is called.
`Bar1` calls a static logger,
`Bar2` calls non-static logger,
`Bar3` calls an injected logger.
Write tests for `BarService`.

Do `Bar` tests affect `Foo` tests?