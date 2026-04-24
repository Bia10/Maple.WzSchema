# **🛠 Universal AI Agent Standards & Repository Health**

This document serves as the mandatory operational framework for all AI Agents (GitHub Copilot, Cursor, Codex, etc.) interacting with this repository. Adherence to these standards is required for all generated code, tests, scripts, and commits.

## **1. Git Commit Standards: Conventional Commits**

To maintain a clean, machine-readable, and professional history, you must strictly adhere to the [Conventional Commits](https://www.conventionalcommits.org/) specification.

* **Format:** \<type\>(\<optional scope\>): \<description\>
* **The Imperative Mood:** Always use the imperative, present tense. Use "Add feature" instead of "Added feature" or "Adds feature."
* **Case Sensitivity:** The type and scope must be strictly **lowercase**.
* **Granularity:** If a task involves both a refactor and a new feature, you are required to split them into two distinct commits.
* **Scope:** This must represent the specific module or component affected (e.g., keys, navigation, defaults).

| Type | Use Case | Example |
| :---- | :---- | :---- |
| **feat** | A new feature for the user. | feat(keys): add MobSkillKeys.Level constants |
| **fix** | A bug fix for the user. | fix(navigation): resolve NPC link loop guard |
| **refactor** | Code change that neither fixes a bug nor adds a feature. | refactor(keys): flatten nested EquipKeys sections |
| **test** | Adding missing tests or correcting existing tests. | test(paths): add boundary checks for MapGroup |
| **chore** | Updating build tasks, package manager configs, etc. | chore(deps): bump Maple.StrongId to 0.2.0 |
| **tool** | Automation scripts or internal dev-tooling. | tool(automation): add C# script for key audit |

## **2. Testing: The "Anti-Pollution" Mandate**

We prioritize **quality and logical failure paths** over coverage metrics. You are forbidden from generating "shallow" or "ritualistic" tests.

* **Ban on Mock-Only Tests:** Do not write tests that only verify if a mock was called. This tests implementation details, not behavior.
* **The "Mutation" Requirement:** Every test must be designed so that if the underlying logic is changed or deleted, the test **fails**.
* **Behavioral Focus:** Focus on state changes, return values, and edge cases.

## **3. Automation: C# 10+ File-Based Apps**

**Bash and PowerShell are deprecated in this repository.** All automation, maintenance, and tooling must be written as **C# 10 File-Based Apps**.

* **Standalone Execution:** Use the single-file format that runs via `dotnet run <filename>.cs`.
* **NuGet Integration:** Use the `#:package` directive at the top of the file to manage dependencies.
* **No Boilerplate:** Do not use `namespace`, `class Program`, or `static void Main`. Write logic directly using Top-Level Statements.
* **Portability:** Use `Path.Combine` or forward slashes. Scripts must be execution-ready on Windows, macOS, and Linux without modification.

## **4. Modern C# 14 Idioms**

Always favor the most concise, high-performance syntax available in C# 14. Do not generate legacy C# code styles.

* **The `field` Keyword:** For properties with logic, use the `field` keyword instead of declaring explicit backing fields.
* **Collection Expressions:** Use the `[]` syntax for all collection initializations and the spread operator `..` for concatenations.
* **Primary Constructors:** Use primary constructors for all classes and structs, particularly for dependency injection.
* **Terseness:** If a method or property can be expressed in a single line, use the expression-bodied member syntax (`=>`).
* **Null-State Safety:** Use `is not null` and the null-coalescing assignment operator `??=`.

## **5. Agent Self-Correction Protocol**

Before finalizing any output, the Agent must perform an internal "Pre-Flight Check":

1. **Logic Check:** Does the generated test actually catch a logic error, or is it just mocking a call?
2. **Script Check:** Is this automation a `.cs` file? If it is `.ps1` or `.sh`, it must be converted.
3. **Syntax Check:** Am I using the `field` keyword, `[]` collections, and Primary Constructors?
4. **Commit Check:** Is my proposed commit message formatted as `type(scope): description`?

**Failure to comply:** If an Agent is informed it has violated these rules, it must immediately revert the offending code and provide a compliant correction.
