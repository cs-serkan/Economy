💰 Unity Economy Core (cs-serkan)
A lightweight, standalone, and modular economy management system designed for Unity. This module handles the core logic for currency accumulation (via hits/clicks) and balance management, completely independent of specific UI or game-specific mechanics.

🚀 Key Features
Modular Architecture: Designed to be a plug-and-play repository for any Unity project.

Decoupled UI Logic: Uses C# Actions (Action<double>) to notify other systems of balance changes, preventing messy code dependencies.

High Precision: Uses double data types to support massive currency values common in idle and incremental games.

Ready-to-Use Trigger: Includes a HitTrigger component that can be easily linked to UI buttons or game objects.

Design Agnostic: Does not force a specific UI; works with TextMeshPro through an optional display script.

🛠 Tech Stack
Engine: Unity 2022.3+ (Recommended)

Language: C#

UI: TextMeshPro (Optional)

Architecture: Singleton Pattern / Event-Driven Programming

📂 Project Structure
IEconomyService.cs: The interface defining the core rules of the economy.

EconomyCore.cs: The engine that manages the gold balance and click values.

HitTrigger.cs: A bridge script to connect user inputs (clicks) to the economy.

EconomyDisplay.cs: A sample UI script to visualize gold updates on a Button or Text.

🎮 How to Use
Setup: Create an empty GameObject named EconomyManager and attach the EconomyCore script.

Interaction: Attach the HitTrigger script to your button or clickable object.

Visuals: Add the EconomyDisplay script to your UI element and drag your TextMeshPro component into the buttonText slot.

Connect: Link the HitTrigger.ExecuteHit method to your button's OnClick() event.

🔧 Installation
Bash
# Clone the repository into your Assets folder
git clone https://github.com/cs-serkan/Economy.git
