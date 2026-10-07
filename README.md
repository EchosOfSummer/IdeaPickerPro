# IdeaPickerPro

IdeaPickerPro is a simple .NET MAUI app for capturing ideas and choosing one at random when you need inspiration.

## Features

- Add and save ideas locally.
- View all saved ideas.
- Delete ideas you no longer need.
- Pick a random idea from your collection.
- Store ideas in a local SQLite database so they remain available between sessions.
- Includes Welcome, Add An Idea, Ideas, and About sections.

## Built With

- C#
- .NET MAUI
- SQLite via `sqlite-net-pcl`
- XAML for the user interface

## Supported Platforms

The project is configured for:

- Android
- iOS
- macOS Catalyst
- Windows 10+

## Getting Started

### Prerequisites

- Visual Studio 2022 with the .NET MAUI workload installed, or another supported .NET MAUI development environment.
- The .NET SDK version required by the project.

### Run the App

1. Clone the repository:

   ```bash
   git clone https://github.com/EchosOfSummer/IdeaPickerPro.git
   cd IdeaPickerPro
   ```

2. Open `IdeaPickerPro.sln` in Visual Studio.
3. Select a target platform or emulator.
4. Build and run the project.

Ideas are stored in a local SQLite database named `ideas.db` within the application's local data directory.

## Project Structure

- `IdeaPickerPro/Views` — application pages and UI logic.
- `IdeaPickerPro/Models` — idea data model and SQLite repository.
- `IdeaPickerPro/Platforms` — platform-specific configuration.
- `IdeaPickerPro/Resources` — images, fonts, icons, and other app assets.

## License

No license has been specified for this repository yet.
