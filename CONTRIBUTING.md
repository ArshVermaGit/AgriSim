# Contributing to AgriSim 🌾

First off, thank you for considering contributing to AgriSim! 🎉

## 📋 Table of Contents

- [Code of Conduct](#code-of-conduct)
- [Getting Started](#getting-started)
- [Development Setup](#development-setup)
- [Making Changes](#making-changes)
- [Submitting Changes](#submitting-changes)
- [Style Guidelines](#style-guidelines)

## 📜 Code of Conduct

This project adheres to a [Code of Conduct](CODE_OF_CONDUCT.md). By participating, you are expected to uphold this code.

## 🚀 Getting Started

### Prerequisites

- **Unity 2022.3 LTS** or later
- **Git** with LFS support
- Basic knowledge of C# and Unity

### Setting Up

1. **Fork** the repository
2. **Clone** your fork:
   ```bash
   git clone https://github.com/YOUR_USERNAME/AgriSim.git
   cd AgriSim
   ```
3. **Open in Unity Hub** and let it import

## 🛠️ Development Setup

### Project Structure

```
AgriSim/
├── Assets/AgriSim/       # Main game assets
│   ├── Scripts/          # C# scripts (namespace: AgriSim)
│   ├── Scenes/           # Unity scenes
│   ├── Art/              # Sprites, animations
│   ├── Audio/            # Sound effects, music
│   └── Prefabs/          # Reusable game objects
├── ProjectSettings/      # Unity project settings
└── Packages/             # Package dependencies
```

### Key Systems

| System           | Location                      | Description              |
| ---------------- | ----------------------------- | ------------------------ |
| GameManager      | `Scripts/GameManager.cs`      | Central game coordinator |
| PlayerController | `Scripts/PlayerController.cs` | Player input & movement  |
| InventorySystem  | `Scripts/InventorySystem.cs`  | Item management          |
| DayCycleHandler  | `Scripts/DayCycleHandler.cs`  | Time & lighting          |
| WeatherSystem    | `Scripts/WeatherSystem.cs`    | Weather effects          |

## ✏️ Making Changes

### Branch Naming

- `feature/your-feature-name` - New features
- `fix/bug-description` - Bug fixes
- `docs/what-you-documented` - Documentation
- `refactor/what-you-refactored` - Code refactoring

### Commit Messages

Use [Conventional Commits](https://www.conventionalcommits.org/):

```
feat: add new crop type (tomatoes)
fix: resolve inventory overflow bug
docs: update README with new controls
refactor: simplify terrain manager logic
```

## 📤 Submitting Changes

1. **Test your changes** in Unity Editor
2. **Ensure no console errors** or warnings
3. **Push to your fork**
4. **Open a Pull Request** with:
   - Clear description of changes
   - Screenshots/GIFs (for visual changes)
   - Reference to related issues

## 🎨 Style Guidelines

### C# Code Style

```csharp
namespace AgriSim
{
    public class ExampleClass : MonoBehaviour
    {
        // Private fields: m_ prefix, camelCase
        private int m_ExampleValue;

        // Public properties: PascalCase
        public int ExampleValue => m_ExampleValue;

        // Methods: PascalCase
        public void DoSomething()
        {
            // Local variables: camelCase
            var localVar = 10;
        }
    }
}
```

### Unity Best Practices

- Use `[SerializeField]` for inspector-exposed private fields
- Prefer `ScriptableObject` for shared data
- Cache component references in `Awake()` or `Start()`
- Use object pooling for frequently spawned objects

## 🎮 Testing Your Changes

1. Open `Assets/AgriSim/Scenes/Loader.unity`
2. Press **Play** in Unity Editor
3. Test affected gameplay systems
4. Check Unity Console for errors

## ❓ Questions?

Open a [Question Issue](https://github.com/ArshVermaGit/AgriSim/issues/new?template=question.md) or reach out via the links in the README!

---

**Happy Contributing!** 🚜🌻
