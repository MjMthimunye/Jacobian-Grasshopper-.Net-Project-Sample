# Jacobian.Grasshopper

**Jacobian.Grasshopper** is a sample Grasshopper plugin project that demonstrates a modern, production-ready approach to developing custom Grasshopper components for both **Rhino 7** and **Rhino 8** from a single codebase.

The project is designed as a reference implementation for handling multi-version compatibility, automated local installation, and packaging Grasshopper add-ins for distribution using **Yak**.

---

## Key Features

- **Multi-target Grasshopper support**
  - Grasshopper 7 (Rhino 7) – `.NET Framework 4.8`
  - Grasshopper 8 (Rhino 8) – `.NET 8`
- Single project and codebase with version-specific build configurations
- Version-aware dependency resolution for:
  - `Grasshopper`
  - `RhinoCommon`
- Automatic post-build installation to the local Grasshopper Libraries folder
- Built-in debugging support for both Rhino 7 and Rhino 8
- Optional release packaging using **Yak**

---

## Build Configurations

| Configuration | Target | Output |
|--------------|--------|--------|
| `GH7` | Rhino 7 / Grasshopper 7 | `bin/GH7/*.gha` |
| `GH8` | Rhino 8 / Grasshopper 8 | `bin/GH8/*.gha` |
| `Debug` / `Release` | General | Depends on configuration |

---

## Local Development & Debugging

### Prerequisites

- Rhino 7 and/or Rhino 8 installed
- Visual Studio 2022 or newer
- Windows (automatic install target is Windows-only)

### Debugging

1. Select either `GH7` or `GH8` configuration
2. Build or start debugging
3. Rhino will launch and Grasshopper will load the plugin automatically

---

## Automatic Installation

After each build, the plugin is automatically copied to:

```
%APPDATA%\Grasshopper\Libraries\<GHSubFolder>
```

Debug symbols (`.pdb`) are also copied to enable full debugging support.

---

## Yak Packaging (Release Only)

When building in `Release` configuration, the project can optionally build a Yak package.

### Requirements

- Rhino 8 installed (Yak CLI included)
- Or provide a custom Yak path via:
  ```
  /p:YakExecutable=path_to_yak
  ```

---

## Intended Use

This project is intended as:

- A starter template for Grasshopper plugin development
- A reference for handling Rhino 7 / Rhino 8 compatibility
- A foundation for professional-grade Grasshopper add-ins

---

## License

Provided as-is for educational and reference purposes.

---

## Author

**Jacobian Dev**
