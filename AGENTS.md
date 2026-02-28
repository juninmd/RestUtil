```markdown
# AGENTS.md File Guidelines

These guidelines outline the requirements for the AGENTS.md file, ensuring a robust, maintainable, and scalable AI agent development system. Adherence to these principles is mandatory for all development efforts.

## 1. DRY (Don't Repeat Yourself)

*   All code must be reusable and encapsulated within functions, classes, or modules.
*   Avoid duplication of logic across multiple files.
*   When a functionality is required, implement it once and reuse it.
*   Favor composition over inheritance where appropriate.

## 2. KISS (Keep It Simple, Stupid)

*   Code should be readable and easy to understand.
*   Minimize complexity within each function and class.
*   Keep functions and classes short and focused.
*   Favor straightforward logic over convoluted algorithms.
*   Prioritize clarity over optimization in most cases.

## 3. SOLID Principles

*   **Single Responsibility Principle:** Each class/module should have a single, well-defined responsibility.
*   **Open/Closed Principle:**  The system should be extensible through well-defined interfaces.  New functionality should be added without modifying existing code.
*   **Liskov Substitution Principle:**  Subclasses should be substitutable for their base classes without altering the correctness of the program.
*   **Interface Segregation Principle:** Clients shouldn't be forced to implement interfaces they don't use.
*   **Dependency Inversion Principle:** Higher-level modules should not depend on lower-level modules; they should depend on abstractions.

## 4. YAGNI (You Aren't Gonna Need It)

*   Implement only the features explicitly required for the current task.
*   Don't add functionality that is not currently needed.
*   Avoid "just in case" considerations – focus on what's necessary.

## 5. Code Structure & File Organization

*   **File Size Limit:** Each file should not exceed 180 lines of code.
*   **Logical Grouping:** Organize code into logical blocks based on functionality or component.
*   **Comments:**  Provide clear and concise comments to explain complex logic or design choices.
*   **Naming Conventions:** Use consistent and descriptive naming conventions for functions, classes, variables, and modules.
*   **Documentation:** Include a brief documentation comment at the beginning of each file outlining its purpose.

## 6. Test Coverage & Mocking

*   **All Development Must Be Productive:**  Prioritize testing.
*   **Mocking:** Utilize mocks and stubs exclusively for unit testing.
*   **Test Cases:** Each function/class/module should have comprehensive unit tests covering all critical paths.
*   **Test Suite:** A robust test suite will be provided that covers all functionality.
*   **Coverage Percentage:** Achieve at least 80% test coverage.

## 7. Data Structures & Algorithms

*   Utilize appropriate data structures for efficient data handling.
*   Choose algorithms that are appropriate for the task.
*   Avoid unnecessary complexity in data structures.

## 8. Dependencies

*   Dependencies should be declared and managed clearly within the file.
*   Use version control for dependencies to facilitate updates and compatibility.
*   Maintain a dependency graph (optional, but recommended for complex systems).

## 9.  Specific Considerations for AGENTS.md

*   **Agent Types:** Clearly define the different types of agents supported within the file.
*   **Communication Protocols:** Specify the communication protocols used by agents (e.g., MQTT, REST API).
*   **State Management:** Define how agent states are managed (e.g., using a state database).
*   **Event Handling:** Implement a robust event handling mechanism.
*   **Logging:**  All agent actions and events should be logged for debugging and monitoring.

## 10.  Coding Style

*   Indentation: Use 2 spaces for indentation.
*   Line Length: Max 120 characters for code lines.
*   Whitespace: Use consistent whitespace around operators and keywords.

## 11.  Testing Frameworks

*   Utilize a chosen testing framework (e.g., pytest, unittest) for all tests.
*   Testing coverage should be actively monitored.

These guidelines are intended as a reference and may be adjusted as the AGENTS.md project evolves.
```