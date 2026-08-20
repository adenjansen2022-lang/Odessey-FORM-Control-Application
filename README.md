# Odessey system Application

## System Overview
This Windows Forms desktop application designed in C# (.NET Framework) allows users to manage space missions, crew members, and system event logs[cite: 1]. The system enables space station administrators to assign personnel, track mission parameters, organize specialized roles, and maintain a detailed event audit trail through a multi-window user interface[cite: 1].

---

## How to Run the Application

1. **Prerequisites**: Ensure Visual Studio 2022 (or newer) with the **.NET Desktop Development** workload is installed (.NET Framework 4.7.2 support).
2. **Open Project**: Launch `Form summative test Practice.slnx` or open the solution file inside Visual Studio[cite: 1].
3. **Build**: Navigate to **Build** > **Build Solution** (or press `Ctrl+Shift+B`).
4. **Run**: Click the **Start** button (or press `F5`) to launch the main form (`frmMain`)[cite: 1].

---

## Key Design Decisions

* **Multi-Form Navigation**: The main window (`frmMain`) serves as a central hub routing users to distinct sub-forms (`Crew`, `Mission`, `Event Log`) to prevent interface clutter and keep tasks separated[cite: 1].
* **Separation of Data & UI**: Domain logic and data fields are defined in standalone domain classes (`CrewClass`, `MissionClass`, `SeniorClass`, `StationCrewClass`), decoupling state logic from Windows Forms UI code (`frmMain.cs`, `Crew.cs`)[cite: 1].
* **Modular Inheritance Structure**: Specialized crew member types extend base attributes via class inheritance, avoiding code duplication across different roles[cite: 1].

---

## Explanation of OOP, Forms, and Events

### Object-Oriented Programming (OOP)
* **Encapsulation**: Domain entities like `CrewClass.cs` and `MissionClass.cs` encapsulate private data fields while exposing controlled public properties and methods[cite: 1].
* **Inheritance**: Derived classes like `SeniorClass.cs` and `StationCrewClass.cs` inherit core properties from `CrewClass.cs`, extending specific functionality required for specialized crew roles[cite: 1].
* **Abstraction**: Form classes interact with instances of class objects without needing to handle their low-level data structures or initialization routines directly[cite: 1].

### Forms
* **User Interface**: Windows Forms (`Form`) act as graphical user interfaces (GUIs).
* **Main Application Window**: `frmMain.cs` acts as the primary parent window[cite: 1].
* **Sub-Windows**: Child forms (`Crew.cs`, `Mission.cs`, `Event Log.cs`) handle specific domain tasks such as viewing mission status, registering new crew members, or reading event logs[cite: 1].

### Events
* **Event-Driven Architecture**: UI elements rely on user actions (such as clicking buttons or selecting menu items) to trigger specific listener methods[cite: 1].
* **Event Handlers**: Examples include `button_Click` or `form_Load` handlers, which process input, instantiate domain objects, and update control displays on demand[cite: 1].
