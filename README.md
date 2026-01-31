# AgriSim

AgriSim is a 2D farming simulation game built with Unity. It features a robust set of systems including a day/night cycle, weather effects, inventory management, and farming mechanics.

## Features

- **Farming System**: Cultivate your land! Use tools to till soil, plant crops, water them, and harvest the produce.
- **Day/Night Cycle**: A fully dynamic time system that affects lighting and shadows. Watch the sun rise and set as you work on your farm.
- **Weather System**: Dynamic weather patterns including Sunny, Rainy, and Thunderstorm conditions that interact with the game world.
- **Inventory Management**: A smart inventory system that supports item stacking, equipping tools, and managing resources.
- **Economy**: Buy seeds and tools, and sell your harvested crops at the market stall to earn coins.
- **Save & Load**: Persistent game state allows you to save your progress (F5) and load it back (F9) at any time.
- **Scene Transitions**: Seamless transitions between outdoor farm areas and indoor environments.

## Controls

### Keyboard & Mouse

- **Move**: `W`, `A`, `S`, `D` or Arrow Keys
- **Sprint**: `Left Shift`
- **Interact**: `E`
- **Use Tool / Action**: `Space` or `Left Mouse Click`
- **Next Item**: `2`
- **Previous Item**: `1`
- **Save Game**: `F5`
- **Load Game**: `F9`

### Gamepad

- **Move**: Left Stick / D-Pad
- **Look**: Right Stick
- **Interact**: North Button (Y/Triangle)
- **Use Tool / Action**: South Button (A/Cross)
- **Next Item**: D-Pad Right
- **Previous Item**: D-Pad Left
- **Sprint**: Left Stick Press

## Getting Started

1. **Open the Project**: Open the `AgriSim` folder in Unity Hub (Recommended Version 2022.3 or later).
2. **Load the Scene**: Navigate to `Assets/AgriSim/Scenes` and open **MainMenu** or **Loader**.
3. **Play**: Hit the Play button in the Unity Editor to start your farming adventure.

## Project Structure

- **GameManager**: Central coordinator for time, weather, and global state.
- **PlayerController**: Handles player movement, input, and interaction logic.
- **InventorySystem**: Manages player items and equipment.
- **DayCycleHandler**: Controls the visual progression of the day, including lighting and shadows.
- **TerrainManager**: Manages the tile-based farming interactions.

## Credits

Based on the _Happy Harvest_ 2D Sample project by Unity Technologies.
