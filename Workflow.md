# Project Nexus: Project Management Workflow

This document defines the official process for how all work on the **Nexus** project is tracked and managed. Our workflow is designed for clarity, transparency, and a complete historical record of every task.

---

### 🏛️ The Organizational Foundation

All project management will be handled within the **Issues** tab of our GitHub repository. We will use three core GitHub features to structure our work.

#### 1. Milestones 🎯
* **Purpose:** A Milestone represents a major phase of our project. Think of it as a large container for a collection of related tasks.
* **Usage:** We will create Milestones that correspond to our project phases (e.g., `Phase 1: Roster Analysis & Core Models`). Every task (Issue) will be assigned to a Milestone to track our progress on high-level goals.

#### 2. Labels 🏷️
* **Purpose:** Labels are color-coded tags used to categorize each task. They allow us to quickly understand the nature of a task at a glance.
* **Usage:** We will apply one or more labels to every Issue. For example, a task to create a new C# class would be labeled `Type: Feature` and `Domain: Database`.

#### 3. Issues 📝
* **Purpose:** An Issue is the central unit of work. **Every single task, bug report, or idea must be created as an Issue.** This ensures that all work is documented, discussable, and trackable from start to finish.
* **Usage:** Before any work begins, a detailed Issue must be created. This serves as the single source of truth for what needs to be done for that task.

---

### 🔄 The Step-by-Step Process

Every task, from a small bug fix to a major new feature, will follow this five-step lifecycle to ensure quality and traceability.

**Step 1: Task Creation (The Issue) 📝**
* An **Issue** is created on GitHub using our defined templates. It's assigned to a Milestone and given appropriate Labels. The task is now officially logged.

**Step 2: Begin Work (The Branch) 🌿**
* A new Git **branch** is created from our `main` branch. Think of the `main` branch as our official master copy. Creating a branch is like making a photocopy; you can work on it freely without any risk to the original.

**Step 3: Save Progress (The Commit) 💾**
* Changes are **committed** frequently to the branch. Each commit is a snapshot of progress on the task.

**Step 4: Propose Changes (The Pull Request) 📬**
* When the work is complete, a **Pull Request (PR)** is opened. This is a formal request to merge the changes from your branch (the photocopy) back into the `main` branch (the master copy). It's where we review the work.

**Step 5: Finalize (Merge & Close) ✅**
* After the Pull Request is reviewed and approved, it is **merged**. The new code is now officially part of the project, and the original Issue is automatically closed.