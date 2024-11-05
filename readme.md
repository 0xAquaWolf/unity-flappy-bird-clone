# Unity GitHub Tutorial Project

A test repository demonstrating how to properly set up and manage Unity projects with Git and GitHub.

## Project Setup

### Prerequisites

- Unity (version used in this project: [your Unity version])
- Git
- Git LFS (Large File Storage) - **Required Installation**
- GitHub Desktop (optional, but recommended for beginners)

### Installing Git LFS

1. **Windows**:

   ```bash
   # Using Chocolatey
   choco install git-lfs

   # Or download and install from:
   # https://git-lfs.github.com/
   ```

2. **macOS**:

   ```bash
   # Using Homebrew
   brew install git-lfs
   ```

3. **Linux (Ubuntu/Debian)**:
   ```bash
   curl -s https://packagecloud.io/install/repositories/github/git-lfs/script.deb.sh | sudo bash
   sudo apt-get install git-lfs
   ```

After installation, initialize Git LFS:

```bash
git lfs install
```

### Initial Setup Steps

1. Create a `.gitignore` file in your project root with Unity-specific ignores:

```
# Unity generated
[Ll]ibrary/
[Tt]emp/
[Oo]bj/
[Bb]uild/
[Bb]uilds/
[Ll]ogs/
[Uu]ser[Ss]ettings/

# Never ignore Asset meta data
![Aa]ssets/**/*.meta

# Visual Studio / VS Code
.vs/
.vscode/
*.csproj
*.unityproj
*.sln
*.suo
*.tmp
*.user
*.userprefs
*.pidb
*.booproj
*.svd
*.pdb
*.mdb
*.opendb
*.VC.db
```

2. Configure Unity Project Settings:

   - Edit → Project Settings → Editor
   - Set "Version Control Mode" to "Visible Meta Files"
   - Set "Asset Serialization Mode" to "Force Text"

3. Configure Git LFS for Unity file types:

   ```bash
   # Initialize your Git repository if you haven't already
   git init

   # Set up Git LFS tracking for common Unity asset types
   git lfs track "*.psd"
   git lfs track "*.fbx"
   git lfs track "*.wav"
   git lfs track "*.mp3"
   git lfs track "*.tga"
   git lfs track "*.png"
   git lfs track "*.jpg"
   git lfs track "*.mp4"
   git lfs track "*.mov"
   git lfs track "*.fbx"
   git lfs track "*.obj"
   git lfs track "*.unitypackage"

   # Commit the .gitattributes file
   git add .gitattributes
   git commit -m "Configure Git LFS tracking"
   ```

## Best Practices

### Commit Guidelines

- Commit frequently with clear, descriptive messages
- Stage and commit related changes together
- Break large changes into smaller, logical commits

### Working with Large Files

- Use Git LFS for:
  - Large texture files
  - Audio files
  - 3D models
  - Any binary file over 100MB

### Branch Strategy

- `main`: Stable, production-ready code
- `develop`: Active development branch
- Feature branches: `feature/feature-name`
- Bug fix branches: `fix/bug-description`

## Common Commands

```bash
# Check Git LFS status
git lfs status

# Check tracked file patterns
git lfs track

# See which files are being tracked by Git LFS
git lfs ls-files

# Pull including LFS files
git lfs pull
```

## Troubleshooting

### Common Issues

1. **Git LFS not installed**

   - Error: `git: 'lfs' is not a git command`
   - Solution: Install Git LFS following the installation steps above

2. **Meta Files Missing**
   - Solution: Ensure "Visible Meta Files" is selected in Unity Editor settings
3. **Large File Rejection**

   - Solution: Verify Git LFS is properly tracking your file types
   - Check file is tracked: `git lfs track`
   - Verify LFS status: `git lfs status`

4. **Merge Conflicts**
   - Solution: Carefully resolve conflicts in Scene and Prefab files
   - Consider using Unity's Smart Merge tool

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

## Acknowledgments

- Unity Documentation
- GitHub Guides
- Git LFS Documentation