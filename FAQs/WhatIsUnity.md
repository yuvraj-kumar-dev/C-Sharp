# Chapter 2 : What is Unity
---
- What is Unity Hub?
Unity Hub is a launcher and management tool for Unity.
It lets you install Unity versions, create/open projects, manage modules (e.g., Android build tools), and sign in to your Unity account.
---
- Do I need to create a Unity account to use Unity?
Yes, a Unity account is required for:
  - Activating licenses (even free Personal version)
  - Accessing Unity services (Asset Store, Cloud Build, etc.)
  - Managing projects via Unity Hub
---
- How do I install Unity Editor?
  - Download Unity Hub from https://unity.com/download
  - In Unity Hub, go to Installs → Add.
  - Choose a Unity version (LTS recommended) and required modules (e.g., Windows Build, Android, iOS).
--- 
- What are the main windows I should be faimiliar with Unity?
  - Scene View – Build your game world.
  - Game View – See how it looks during play.
  - Hierarchy – List of all GameObjects in the scene.
  - Inspector – View and edit properties of selected objects.
  - Project Window – Manage assets like scripts, textures, and models.
  - Console – View errors, warnings, and debug messages.
--- 
- How do I create a new game object in Unity?
  - Right-click in the Hierarchy window → 3D Object or 2D Object → choose (e.g., Cube, Sphere).
---
- What is component in Unity?
A Component is a piece of functionality you can attach to a GameObject.
Examples: Transform (position/rotation), Rigidbody (physics), Collider (collision), Script (custom behavior).
---
- How do I run and test my Unity Project?
Click the Play button (top center of the Unity Editor).
  - Game View shows the project in real time.
  - Click Play again to stop.
---
- Can I customize the Unity Editor Layout?
Yes. You can move, resize, and dock windows.
Save layouts via Window → Layouts → Save Layout.
---
- What is Script in Unity and How do I create one?
A Script is a C# file that controls GameObject behavior.
To create:
  - Right-click in Project → Create → C# Script
  - Name it, then double-click to edit in Visual Studio.
---
- How do I attach a script to a GameObject?
Select the GameObject → Inspector → Add Component → Scripts → [Script Name].
