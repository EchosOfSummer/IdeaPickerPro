# IdeaPickerPro

IdeaPickerPro is a lightweight cross-platform idea management app built with .NET MAUI. It helps users capture ideas, keep them organized in a local collection, and select a random idea whenever they need inspiration.

The app is designed for quick, distraction-free idea capture. Whether you use it for project concepts, creative prompts, weekend activities, or brainstorming notes, your ideas are saved locally on the device and remain available between sessions.

## Features

- **Add ideas** — Enter a new idea and save it to your personal collection.
- **View saved ideas** — Browse all ideas currently stored in the app.
- **Delete ideas** — Remove ideas that are no longer useful, with a confirmation prompt before deletion.
- **Pick a random idea** — Select a random saved idea from the Welcome page for inspiration.
- **Local persistence** — Ideas are stored in a local SQLite database and do not require an internet connection.
- **Empty-state handling** — The app provides helpful messages when no ideas have been added yet.
- **Simple navigation** — The app includes dedicated Welcome, Add An Idea, Ideas, and About sections.
- **Cross-platform UI** — Built as a single .NET MAUI project for multiple operating systems.

## How It Works

1. Open the **Add An Idea** page.
2. Enter an idea in the text field.
3. Select **Save** to store it locally.
4. Open the **Ideas** page to review your collection.
5. Use the Welcome page's random idea action to receive a suggestion.
6. Delete individual ideas from the Ideas page when they are no longer needed.

When the random idea action is used, the app loads the saved ideas from the local database, chooses one at random, and displays it briefly. If the collection is empty, the app asks the user to add ideas first.

## Data Storage

IdeaPickerPro uses SQLite for local data storage through the `sqlite-net-pcl` package. The database is created automatically in the application's local data directory using the filename `ideas.db`.

Each idea contains:

- An automatically generated numeric ID.
- The text entered by the user.

The app creates the database table when the repository is initialized. Saving, loading, and deleting ideas are handled by the repository in `IdeaPickerPro/Models/Repository.cs`.

All data is stored locally on the device. This project does not currently include user accounts, cloud synchronization, or remote APIs.

## Built With

- **C#** — application logic and data models.
- **.NET MAUI** — cross-platform application framework.
- **XAML** — user interface definitions and layouts.
- **SQLite** — local persistence through `sqlite-net-pcl`.
- **.NET MAUI Shell** — application navigation and tab structure.

## Supported Platforms

The project is configured to target:

- Android
- iOS
- macOS Catalyst
- Windows 10+

The project currently targets .NET 7 platform frameworks as defined in `IdeaPickerPro/IdeaPickerPro.csproj`.

## Project Structure

```text
IdeaPickerPro/
├── Models/
│   ├── Glitch.cs          # Visual background/effect behavior
│   ├── Idea.cs            # SQLite idea entity
│   └── Repository.cs      # Local database operations
├── Platforms/             # Platform-specific configuration
├── Properties/            # Application metadata and launch settings
├── Resources/             # Fonts, images, icons, splash screen, and assets
├── Views/
│   ├── AboutPage.xaml     # About page UI
│   ├── AddPage.xaml       # Add idea UI
│   ├── IdeasPage.xaml     # Saved ideas list and deletion UI
│   └── MainPage.xaml      # Welcome page and random idea UI
├── App.xaml               # Application resources
├── App.xaml.cs            # Shell navigation setup
├── MauiProgram.cs         # MAUI application configuration
└── IdeaPickerPro.csproj   # Project and dependency configuration
```

## Getting Started

### Prerequisites

Install one of the following development environments:

- Visual Studio 2022 with the .NET MAUI workload installed.
- .NET MAUI tooling for your preferred supported development environment.
- The .NET SDK and platform workloads required by the target device or emulator.

Because this project targets .NET 7, you may need the corresponding .NET 7 SDK and workloads to build it without changing the project configuration.

### Clone the Repository

```bash
git clone https://github.com/EchosOfSummer/IdeaPickerPro.git
cd IdeaPickerPro
```

### Run the App

1. Open `IdeaPickerPro.sln` in Visual Studio.
2. Restore the NuGet packages when prompted.
3. Select an Android emulator, iOS simulator, Windows target, or another configured platform.
4. Build and run the project.

For command-line development, use the appropriate .NET MAUI command for the platform you want to target. Platform setup requirements can vary depending on the operating system and device tooling.

## Development Notes

- The application uses a single-project .NET MAUI structure.
- Debug logging is enabled through `Microsoft.Extensions.Logging.Debug` in debug builds.
- The app uses the default MAUI font resources, including Open Sans variants.
- The local database is initialized automatically when a repository instance is created.
- No external service or network connection is required for the core functionality.

## Current Limitations

- Ideas are stored only on the current device.
- There is no cloud backup or synchronization.
- Ideas currently contain text only; categories, tags, favorites, and editing are not implemented.
- The project does not currently include automated tests or a CI/CD workflow.
- A production signing and distribution configuration has not been documented yet.

## Potential Future Improvements

Possible enhancements include:

- Edit existing ideas.
- Add categories, tags, or favorites.
- Filter and search the idea collection.
- Add export and import support.
- Add optional cloud synchronization.
- Add automated unit and UI tests.
- Add application screenshots and release packages.

## License

No license has been specified for this repository yet. Add a license file if you want to define how others may use, modify, and distribute the project.
