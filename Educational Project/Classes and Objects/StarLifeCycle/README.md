# StarLifecycleSimulator

A C# console app that simulates the lifecycle of stars—from their radiant youth to their explosive demise.

---

## Overview

Stars are the engines of the universe. This project models a simplified version of a star’s lifecycle using object-oriented programming in C#. It’s designed to be educational, extensible, and just a little dramatic.

---

## Concepts & Theory

- **Main Sequence**: Stars shine steadily while converting hydrogen into helium.
- **Aging**: Brightness decays over time as fuel depletes.
- **Supernova**: Massive stars explode, ending their lifecycle.
- **Unknown Stars**: Simulates stars with undefined types—because space is full of mysteries.

---

## How It Works

```csharp
Star sun = new Star("Sun", "G-Type");
sun.Shine();
sun.GrowOlder();
sun.Supernova();
