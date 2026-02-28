```markdown
# RestUtil

## Description

A library for assisting with the manipulation of REST API requests via C#

## Installation

1.  Clone the repository: `git clone https://github.com/your-username/RestUtil.git`
2.  Navigate to the project directory: `cd RestUtil`
3.  Install dependencies: `dotnet build` (This will create a NuGet package).

## Usage

*   **Creating Requests:**
    *   `RestUtil.CreateRequest(method, body, headers)` – Creates a REST API request.
    *   `RestUtil.GetRequest(url)` – Retrieves a REST API request.
*   **Modifying Requests:**
    *   `RestUtil.UpdateRequest(request)` – Updates an existing request.
    *   `RestUtil.DeleteRequest(request)` – Deletes a request.
*   **Formatting Requests:**
    *   `RestUtil.Header(header, value)` – Adds a custom header to a request.
    *   `RestUtil.Body(data)` – Adds data to a request body.
*   **Example:**
    ```csharp
    // Use RestUtil.CreateRequest to create a GET request to /users
    RestUtil.CreateRequest("GET", {"name": "John Doe"}, {"Authorization": "Bearer your_token"}} )
    ```
```