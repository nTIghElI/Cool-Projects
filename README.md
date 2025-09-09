Cool-Projects: A Collection of C# Educational Projects
======================================================

This repository contains a series of projects created while learning C# and fundamental programming concepts like Data Structures and Algorithms.

My Daily Git Workflow (A Quick Reference Guide)
-----------------------------------------------

This is a simple, repeatable workflow for saving work and keeping the local repository in sync with GitHub.

### Step 1: `git pull` (Start of Session)

**Always run this command before starting new work.** It fetches the latest version of the project from GitHub and ensures your local copy is up-to-date.

```
git pull

```

### Step 2: Make Changes

Work on the code. Add new features, fix bugs, create new projects, etc.
dotnet new console -n //AppName

### Step 3: `git add` (Stage Changes)

After making changes, you need to stage them. This tells Git which files you want to include in your next save point (commit).

To see what you've changed:

```
git status

```

To stage all of your changes:

```
git add .

```

### Step 4: `git commit` (Save Your Work)

A commit is a permanent snapshot of your staged changes. Always use a clear, descriptive message.

```
git commit -m "Your descriptive message goes here"

```

*Example: `git commit -m "Implement factorial function using recursion"`*

### Step 5: `git push` (Upload to GitHub)

This command uploads your new commit(s) from your local machine to the remote repository on GitHub.

```
git push

```