# ChatApp — Cross-Platform Messenger

A modern, cross-platform messenger application built with .NET MAUI, following the MVVM pattern with dependency injection.



Based on this [design](https://dribbble.com/shots/11470136-A-Messaging-App-Concept) by [Tannaz Sadeghi](https://dribbble.com/tannazsadeghi).

---

## What This App Will Be

When development is complete, ChatApp will be a fully-featured messenger application comparable to Telegram or WhatsApp, available on **Android, iOS, macOS, and Windows**.

### Core Features

- **Real-time messaging** — instant message delivery via SignalR/WebSocket
- **User authentication** — login, registration, JWT tokens, biometric auth
- **One-on-one & group chats** — create, manage, and switch conversations
- **Media sharing** — photos, files, voice messages, emoji reactions
- **Message management** — edit, delete, reply, forward messages
- **Typing indicators & read receipts** — know when contacts are active
- **Push notifications** — never miss a message via FCM/APNs
- **Offline support** — local SQLite cache for messages and drafts
- **User profiles** — avatars, status, bio, privacy settings
- **Search** — find chats, messages, and contacts instantly
- **Dark mode** — full theme support across all platforms
- **End-to-end encryption** — secure communication

---

## Requirements

| Requirement | Minimum | Recommended |
|---|---|---|
| **.NET SDK** | 9.0 | 9.0+ |
| **Visual Studio 2022** | 17.12+ | Latest with MAUI workload |
| **OS — Windows** | Windows 10 19041+ | Windows 11 |
| **OS — macOS** | macOS 13+ | macOS 14+ |
| **Android SDK** | API 21 | API 34 |
| **Xcode** (for iOS) | 15.0+ | Latest |

---

## Getting Started

### 1. Clone the Repository

```bash
git clone <repository-url>
cd chat-app
```

### 2. Install .NET MAUI Workload

```bash
dotnet workload install maui
```

### 3. Restore NuGet Packages

```bash
cd "src/NET MAUI/ChatApp"
dotnet restore
```

### 4. Run the Application

**Windows:**
```bash
dotnet build -t:Run -f net9.0-windows10.0.19041.0
```

**Android (device or emulator must be running):**
```bash
dotnet build -t:Run -f net9.0-android
```

**macOS:**
```bash
dotnet build -t:Run -f net9.0-maccatalyst
```

**iOS (macOS required):**
```bash
dotnet build -t:Run -f net9.0-ios
```

### Alternative: Visual Studio

1. Open `src/NET MAUI/ChatApp.sln` in Visual Studio 2022
2. Select the target platform from the debug dropdown
3. Press **F5** to build and run

---

## Project Structure

```
chat-app/
├── README.md
├── ARCHITECTURE.md          # Detailed architecture documentation
├── AGENT.md                 # Current capabilities & development roadmap
├── images/                  # Screenshots and design assets
└── src/
    ├── NET MAUI/ChatApp/    # Active .NET MAUI project (main codebase)
    │   ├── Models/          # Data entities (User, Message)
    │   ├── Views/           # XAML pages and data templates
    │   ├── ViewModels/      # MVVM view models (CommunityToolkit.Mvvm)
    │   ├── Services/        # Business logic and navigation
    │   ├── Controls/        # Custom UI controls
    │   ├── Converters/      # Value converters
    │   ├── Resources/       # Fonts, images, styles
    │   ├── Platforms/       # Platform-specific code
    │   └── MauiProgram.cs   # App entry point & DI configuration
    └── Xamarin.Forms/       # Legacy Xamarin project (archived)
```

---

## Tech Stack

| Layer | Technology |
|---|---|
| **UI Framework** | .NET MAUI (net9.0) |
| **MVVM Toolkit** | CommunityToolkit.Mvvm |
| **DI** | Microsoft.Extensions.DependencyInjection |
| **Target Platforms** | Android, iOS, MacCatalyst, Windows |

---

## Current State

The application has a **fully functional UI** with two screens (home and chat detail), mock data, and navigation. The architecture is in place with DI, service interfaces, and source-generated ViewModels.

What remains is connecting to a real backend: authentication, REST APIs, real-time messaging, media handling, notifications, and offline storage. See [AGENT.md](AGENT.md) for the complete development roadmap.

---

## Architecture

See [ARCHITECTURE.md](ARCHITECTURE.md) for detailed documentation on the app's architecture, data flow, component design, and known issues.
