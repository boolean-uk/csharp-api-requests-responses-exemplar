# C# API Requests & Responses

## Learning Objectives
- Build an API to a defined specification
- Build endpoints that can support GET, POST, PUT, DELETE requests
- Use HTTP response codes to differentiate response types
- Use JSON to send structured messages between a client and server

## Instructions

1. Fork this repository
2. Clone your fork to your machine
3. Open the project in Visual Studio


## Requirements

Requirements for this exercise is presented in the form of API documentation using the OpenAPI spec.

API documentation is usually defined before building the actual API so that the client and server can both be developed at the same time, working to satisfy the same specification.

As an example, consider this simple API spec:

```
GET /meetings
200 OK response:
[
    {
        "id": integer,
        "client": "string",
        "isAccepted": boolean
    }
]

POST /meetings
Payload:
{
    "client": "string",
    "isAccepted": boolean
}
201 CREATED response:
{
    "id": integer,
    "client": "string",
    "isAccepted": boolean
}
```

It can be a little confusing at first glance but it contains everything a developer needs to begin building the API.

- The spec defines one route: `/meetings`
- The spec defines two HTTP methods for that route: `GET` and `POST`
- The spec defines what the response status code and the response body for both routes should look like

As a developer, it's your job to build the API so that it satisfies the spec exactly. Attention to detail is important!

[Here's the spec for this exercise.](https://boolean-uk.github.io/csharp-api-requests-responses/) Spend some time getting familiar with it and pay close attention to the details.

The `Students` class is already partially built for you to help you get started. This is the last time you'll receive boilerplate code as a starter, so spend some time understanding it. Experiment & change it until you feel comfortable.  

**You are free to change the provided code in this project but you must implement a minimal api with a repository layer and data layer.**


## Extensions

The extensions is presented as a separate API spec. 

This one will have you considering the concept of unique identifiers for records.

[Here's the extension spec.](https://boolean-uk.github.io/csharp-api-requests-responses/extensions)
