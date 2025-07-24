# Forthlings

# Forthlings - Interactive GNU Forth (Gforth) Learning Platform

![Forthlings Logo](https://raw.githubusercontent.com/nulvox/forthlings/refs/heads/main/forthlings.png)

## Prerequisites

### Gforth Installation (Required)
Forthlings requires Gforth to be installed. Choose your platform:

#### Ubuntu/Debian Linux
```bash
sudo apt update
sudo apt install gforth
```

#### MacOS (Homebrew)
```bash
brew install gforth
```

#### Windows
1. Download Gforth from https://www.gnu.org/software/gforth/
2. Follow the installer instructions
3. Add Gforth to your system PATH

### Verify Installation
```bash
gforth --version
```
You should see version information if installed correctly.

## Getting Started

2. Clone this repository:
```bash
git clone https://github.com/yourusername/forthlings.git
cd forthlings
```

3. Run the exercises:
```bash
# List available exercises
./forthlings list

# Run a specific exercise
./forthlings run hello-world
```

## Exercises Overview
Exercises are organized by topic:
1. Basics
2. Control Flow
3. Functions
4. Data Structures
5. Compiler

Each exercise includes:
- Problem statement
- Reference to the Gforth manual
- Solution checker

## Contributing
We welcome contributions! Please see CONTRIBUTING.md for guidelines.

## License
MIT License - See LICENSE file for details
